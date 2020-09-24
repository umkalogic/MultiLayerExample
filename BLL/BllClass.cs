using DAL;

namespace BLL
{
    //contains entities as classes
    public class BllClass
    {
        private DalClass dal = new DalClass();
        private string data; //it could be a class type

        public BllClass(string path)
        {
            data = dal.ReadData(path);
        }

        public bool Contains(string str2)
        {
            return data.Contains(str2); ;
        }

        public int IndexOf(string str2)
        {
            return data.IndexOf(str2);
        }
    }
}
