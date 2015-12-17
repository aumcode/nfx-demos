The project demonstrates different methods which you can use
while working with laconic-formatted config files of your applications:

Attributes
One of the main purpose of any configuration file is to fill class istances with values stored in it.
With *.laconf configuration you can do it by placing 'NFX.Environment.ConfigureAttribute' on class members 
and then call 'ConfigAttribute.Apply()' to automatically supply your class members with config values.
You can also implement 'NFX.Environment.IConfigurable' interface to achieve more precise control over filling class
from configuration node.

Merge
While working with configurations you can merge them together with 'NFX.Environment.Configuration.CreateFromMerge()'.
It creates a new configuration from ordered merge result of two other nodes which can be from different configurations.
The first operand is a 'base' node that data is defaulted from.
And the second one contains overrides/additions of/to data from base node.
Also you can influence on merging process with '_override' pragma.

Include
If you need include some sub-tree in existing configuration you can do this in two ways:
  1. Using 'NFX.Environment.Configuration.Include()'. It completely replaces existing node with another node tree,
positioning the new tree in the place of local node. Existing node is deleted after this operation completes,
in its place child nodes from other node are inserted preserving their existing order.
Attributes of other node get merged into parent of existing node.
  2. Using include pragmas - sections with specified names ('_include' by default) and
calling 'NFX.Environment.ConfigNode.ProcessIncludePragmas()' then which replaces all pragmas with pointed to 
configuration file content as obtained via the call to file system specified in every pragma.
If no file system specified then local file system is used. Note: this method does not process new include pragmas
that may have fetched during this call.

JSON <--> Laconic
You can convert laconic configuration to JSON format and backwards. Use corressponding methods:
'NFX.Environment.ConfigNode.ToJSONDataMap()' and 'NFX.Serialization.JSON.JSONDataMap.ToConfigNode()'.

CommandArgsConfiguration
You can create special type of configuration 'NFX.Environment.CommandArgsConfiguration' based on arguments supplied
from command line which is 'string[]'. Arguments start with either '/' or '-' prefix. If any argument is not prefixed then
it is written as an auto-named ('?<index>') attribute node of the root with its value set, otherwise a section (under root)
with argument's name is created. Any argument may have options. Any option may either consist of name or name value pair
delimited by '='. Argument options are written as attribute nodes of their corresponding sections. If option value specified
without name (without '=') then option is auto-named.

Navigation
To get a link to some node in your configuration tree you can use two ways:
  1. "Step-by-step" access. This way can be used in application only and supposes the using of next methods
of 'NFX.Environment.ConfigNode':
indexer '[<subsection_name>]' - for access to subsection
'AttrByName(<name_of_attribute>)' or 'AttrByIndex(<index_of_attribute>)' - for access to attribute
  2. Paths. This way can be use directly in the configuration. Use:
'/' - as leading char for root, 
'..' - for step up,
'$' - for attribute name,
'[int]' -  for access to subsection or attribute by index,
'section[value]' - for access using value comparison of named section,
'section[attr=value]' - for access using value of sections named attr
Multiple paths may be coalesced using '|' or ';'. If path starts from '!' then exception will be thrown if such
node does not exist. In application you can use 'NFX.Environment.ConfigNode.Navigate(<path>)' which navigates
the '<path>' and return the appropriate node.
To return the path from the root to the node 'NFX.Environment.ConfigNode.RootPath()' is used. 

Evaluation of variables
In your configurations you can use "variables" which can take values of configuration tree nodes. To get the value of
some node construction '$(<path_to_the_node>)' is used (for more details about paths see 'Navigation' tab).
Besides that you can work with environment variables ('~<name_of_variable>') and you can even make your own variables resolver.
Also to expand the functionality of variables using macro inserts ('::<macro_name>') can be added.

Scripts
You can make script inserts in your configuration.
To execute configuration scripts use 'NFX.Environment.ScriptRunner.Execute()'.