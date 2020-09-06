// Title: Removes the key/value pair "CEM_Blacklist" / "1" from the annotation metadata of each selected column
//  
// Author: Tom Martens, twitter.com/tommartens68
// 
// This script is considered being a "helper" script for the script "CreateExplicitMeasures".
// When executed, the script will loop through all selected columns. 
// The existing annotation "CEM_Blacklist" will be removed from the column metadata

foreach(var c in Selected.Columns)
{    
    c.RemoveAnnotation("CEM_Blacklist");
}