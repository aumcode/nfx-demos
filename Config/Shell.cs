using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Config.LaconicConfig.Classes;
using NFX;
using NFX.Environment;
using NFX.Serialization.JSON;

namespace Config.LaconicConfig
{
    public partial class Shell : Form
    {
        private const string INCLUDE_FILE_PATH = "Resources\\src_config\\incl.laconf";
        private const string TEXT_BOXES_NODE = "text_boxes";
        private const string TEXT_BOX_ATTR_NAME = "name";
        private const string TEXT_BOX_ATTR_PATH = "path";
        private const string TEXT_BOX_ATTR_RTF = "rtf";

        public Shell()
        {
            InitializeComponent();
            loadConfigurationsAndInfos();
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        }

        /// <summary>
        /// Load text into text boxes from external files using the configuration of the application.
        /// </summary>
        private void loadConfigurationsAndInfos()
        {
            var textBoxes = App.ConfigRoot[TEXT_BOXES_NODE];
            if (textBoxes == null)
                return;

            foreach (var tb in textBoxes.Children)
            {
                var controlName = tb.AttrByName(TEXT_BOX_ATTR_NAME).Value;
                var path = tb.AttrByName(TEXT_BOX_ATTR_PATH).Value;
                var isRTF = tb.AttrByName(TEXT_BOX_ATTR_RTF).ValueAsBool();

                var searchResult = this.Controls.Find(controlName, true);
                if (searchResult.Count() == 0)
                    continue;
                var textBox = searchResult[0] as RichTextBox;

                try
                {
                    if (isRTF)
                    {
                        var txt = File.ReadAllText(path);
                        textBox.Rtf = txt;
                    }
                    else
                        textBox.LoadFile(path, RichTextBoxStreamType.PlainText);
                }
                catch (Exception e)
                {
                    textBox.Text = e.ToMessageWithType();
                }
            }
        }

        private void btnAttributes_Click(object sender, EventArgs e)
        {
            try
            {
                var str = this.confAttributes.Text;
                var conf = LaconicConfiguration.CreateFromString(str);
                var person = new Person();

                ConfigAttribute.Apply(person, conf.Root);

                this.resultAttributes.Text = person.ToString();
            }
            catch(Exception ex)
            {
                this.resultAttributes.Text = ex.ToMessageWithType();
            }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            try
            {
                var confA = LaconicConfiguration.CreateFromString(this.confMergeA.Text);
                var confB = LaconicConfiguration.CreateFromString(this.confMergeB.Text);
                var conf = new MemoryConfiguration();

                conf.CreateFromMerge(confA.Root, confB.Root);

                this.resultMerge.Text = conf.ToLaconicString();
            }
            catch (Exception ex)
            {
                this.resultMerge.Text = ex.ToMessageWithType();
            }
        }

        private void btnInclude_Click(object sender, EventArgs e)
        {
            try
            {
                this.confIncludeFile.SaveFile(INCLUDE_FILE_PATH, RichTextBoxStreamType.PlainText);
                var confA = LaconicConfiguration.CreateFromString(this.confIncludeA.Text);

                if (confA.Root.HasChildren)
                {
                    var rootConfB = this.confIncludeB.Text.AsLaconicConfig();
                    confA.Include(confA.Root[0], rootConfB);
                }
                confA.Root.ProcessIncludePragmas(true);

                this.resultInclude.Text = confA.ToLaconicString();
            }
            catch (Exception ex)
            {
                this.resultInclude.Text = ex.ToMessageWithType();
            }
        }

        private void btnLaconicToJson_Click(object sender, EventArgs e)
        {
            try
            {
                var node = this.txtLaconic.Text.AsLaconicConfig();
                var map = node.ToJSONDataMap();
                this.txtJSON.Text = map.ToJSON(JSONWritingOptions.PrettyPrint);
            }
            catch (Exception ex)
            {
                this.txtJSON.Text = ex.ToMessageWithType();
            }
        }

        private void btnJsonToLaconic_Click(object sender, EventArgs e)
        {
            try
            {
                var map = (JSONDataMap)this.txtJSON.Text.JSONToDataObject();
                var node = map.ToConfigNode();
                this.txtLaconic.Text = node.ToLaconicString();
            }
            catch (Exception ex)
            {
                this.txtLaconic.Text = ex.ToMessageWithType();
            }
        }

        private void btnCommandArgs_Click(object sender, EventArgs e)
        {
            try
            {
                var args = this.txtCommandArgs.Text.Split(new char[] {' '} ,StringSplitOptions.RemoveEmptyEntries);
                var conf = new CommandArgsConfiguration(args);
                this.resultCommandArgs.Text = conf.ToLaconicString();
            }
            catch (Exception ex)
            {
                this.resultCommandArgs.Text = ex.ToMessageWithType();
            }
        }

        private void btnScripting_Click(object sender, EventArgs e)
        {
            try
            {
                var src = LaconicConfiguration.CreateFromString(this.sourceScripting.Text);
                var res = new LaconicConfiguration();
                var runner = new ScriptRunner();
                runner.TimeoutMs = 500; // for slow computers may be increased
                runner.Execute(src, res);
                this.resultScripting.Text = res.SaveToString();
            }
            catch (Exception ex)
            {
                this.resultScripting.Text = ex.ToMessageWithType();
            }
        }

        private void btnVariables_Click(object sender, EventArgs e)
        {
            try
            {
                var conf = LaconicConfiguration.CreateFromString(this.confVariables.Text);
                var src = this.exprVariables.Text;
                var res = src.EvaluateVarsInConfigScope(conf);
                this.resultVariables.Text = res;
            }
            catch (Exception ex)
            {
                this.resultVariables.Text = ex.ToMessageWithType();
            }
        }

        private void btnVariablesClear_Click(object sender, EventArgs e)
        {
            this.exprVariables.Clear();
        }

        private void btnNavigate_Click(object sender, EventArgs e)
        {
            try
            {
                var root = this.confNavigate.Text.AsLaconicConfig();
                var path = this.txtNavigatePath.Text;
                this.txtNavigateValue.Text = root.Navigate(path).Value;
            }
            catch (Exception ex)
            {
                this.txtNavigateValue.Text=ex.ToMessageWithType();
            }
        }
    }
}
