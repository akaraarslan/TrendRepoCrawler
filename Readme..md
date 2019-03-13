Crawler data from a website with Html Agility Pack, Fizzler  (.NET / C#)

### Notes:

#### Installing nuget dependencies on new project 

Install-Package Fizzler.Systems.HtmlAgilityPack  

#### HTML Agility Pack

**HTMLDocument:**
This is a class of information about an html file (encoding, innerhtml). We can load data into HTMLDocument from a URL or from a file.  
**HTMLNode:**
An HTMLNode is equivalent to a tag (li, ul, div, etc.) in HTML.  
--**Name:** The name of the node (div, ul, li).  
--**Attributes**: The list of notes (Attribute is the information of the node such as: src, href, id, class)  
--**InnerHTML**, **OuterHTML**:  
--**SelectNodes (string XPath):** Find the child nodes of the current node, based on the XPath inserted.  
--**SelectSingleNode (string XPath):** Find the first child node of the current node, based on the input xPath.  
--**Descendants (string XPath):** Returns the list of child HTMLNode of the current node.  

#### Fizzler

Fizzler supports CSS selector  
**QuerySelectorAll:** Find the child nodes of the current node, based on the input css selector.
**QuerySelector:** Find the first child node of the current node, based on the input css selector.