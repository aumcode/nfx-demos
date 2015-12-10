using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaconicConfig.Demos.Classes;
using NFX;
using NFX.Environment;

namespace LaconicConfig.Demos
{
    public partial class Shell : Form
    {
        public Shell()
        {
            InitializeComponent();
            loadConfigurationsAndInfos();
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

        /// <summary>
        /// Load text into text boxes from external files using the configuration of the application.
        /// </summary>
        private void loadConfigurationsAndInfos()
        {
            var textBoxes = App.ConfigRoot["text_boxes"];
            if (textBoxes == null)
                return;

            foreach (var tb in textBoxes.Children)
            {
                var controlName = tb.AttrByName("name").Value;
                var path = tb.AttrByName("path").Value;
                var isRTF = tb.AttrByName("rtf").ValueAsBool();
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
    }
}
