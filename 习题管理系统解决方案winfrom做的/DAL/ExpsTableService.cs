using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;
using DAL.Helper;

namespace DAL
{
    public class ExpsTableService
    {


        /// <summary>
        /// 获取实验室的名称
        /// </summary>
        /// <returns></returns>
        public List<string> GetLabRoomName() 
        {
            string sql = "select LabRoom from ExpsTable";
            MySqlDataReader reader = null;
            List<string> labRoomNameList = new List<string>();
            try
            {
                reader = SqlHelper.GetReader(sql);
                if(reader!=null)
                {
                    while(reader.Read())
                    {
                        if (!labRoomNameList.Contains(reader["LabRoom"].ToString()))
                        {
                            labRoomNameList.Add(reader["LabRoom"].ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            { 
                if(reader!=null)
                {
                    reader.Close();
                    
                }
            }
            return labRoomNameList;
        }


        /// <summary>
        /// 根据实验室名称获取实验信息
        /// </summary>
        /// <param name="LabRoom">实验室名称</param>
        /// <returns></returns>
        public List<ExpsTable> GetExpsInfoByLabRoom(string LabRoom)
        {
            string sql = "select ExpName,SceneName from ExpsTable where LabRoom='"+LabRoom+"'";
            MySqlDataReader reader = null;
            List<ExpsTable> expsList = new List<ExpsTable>();
           
            try
            {
                reader = SqlHelper.GetReader(sql);
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        
                        expsList.Add(new ExpsTable()
                        {
                             expName = reader["ExpName"].ToString(),
                             sceneName = reader["SceneName"].ToString()
                        });
                      
                        
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();

                }
            }
            return expsList;
        }
    }
}
