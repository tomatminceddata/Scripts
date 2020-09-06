// Title: Adds a key/value pair "CEM_Blacklist" / "1" as custom annotation to the metadata of each selected column
//  
// Author: Tom Martens, twitter.com/tommartens68
// 
// This script is considered being a "helper" script for the script "CreateExplicitMeasures".
// When executed, the script will loop through all selected columns. A key/value pair ia added to the Annotations
// metadata of each selected column.
// Key: "CEM_Blacklist" , value "1"
// This key/value pair prevents the automatic measure creation by the script "CreateExplicitMeasures"

foreach(var c in Selected.Columns)
{    
    c.SetAnnotation("CEM_Blacklist" , "1");
}