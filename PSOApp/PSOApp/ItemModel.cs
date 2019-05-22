using System;
namespace PSOApp
{
    public class ItemModel
    {
        public string Item_Name { get; set; }
        public string Enemy { get; set; }
        public float DropRate { get; set; }
        public string SectionID { get; set; }
        public string Difficulty { get; set; }

        public override string ToString()
        {
            return Item_Name;
        }
    }
}
