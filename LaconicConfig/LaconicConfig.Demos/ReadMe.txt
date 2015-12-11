The application demonstrates different methods which you can use
while working with laconic-formatted config files of your applications:

Attributes
One of the main purpose of any configuration file is to fill class istances with values stored in it.
With *.laconf configuration you can do it by placing NFX.Environment.ConfigureAttribute on class members 
and then call ConfigAttribute.Apply() to automatically supply your class members with config values.
You can also implement NFX.Environment.IConfigurable interface to achieve more precise control over 
filling class from configuration node.

Merging
While working with configurations you can merge two of them into one with NFX.Environment.Configuration.CreateFromMerge() method.
It creates a new configuration from ordered merge result of two other nodes which can be from different configurations.
The first operand is a "base" node that data is defaulted from.
And the second one contains overrides/additions of/to data from base node.
Also you can influence on merging process with '_override' pragma.