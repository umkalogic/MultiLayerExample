using System;
using System.IO;

namespace DAL
{
    public class DalClass
    {
        public string ReadData(string path)
        {
            string data;
            FileStream fin;
            try
            {
                fin = new FileStream(path, FileMode.Open);
            } catch (IOException ex)
            {
                throw ex;
            }
            StreamReader fstr = new StreamReader(fin);
            try
            {
                data = fstr.ReadToEnd();
            }
            catch (IOException ex)
            {
                throw ex;
            } finally
            {
                fstr.Close();
            }
            return data; //could return a class object
        }
    }
}
