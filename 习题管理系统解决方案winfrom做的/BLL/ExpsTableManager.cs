using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using DAL;
using Model;

namespace BLL
{
    public class ExpsTableManager
    {
        ExpsTableService expsService = new ExpsTableService();
         /// <summary>
        /// 获取实验室的名称
        /// </summary>
        /// <returns></returns>
        public List<string> GetLabRoomName()
        {
            try
            {
                return expsService.GetLabRoomName();
            }
            catch (Exception)
            {
                
                throw;
            }
        }


         /// <summary>
        /// 根据实验室名称获取实验信息
        /// </summary>
        /// <param name="LabRoom">实验室名称</param>
        /// <returns></returns>
        public List<ExpsTable> GetExpsInfoByLabRoom(string LabRoom)
        {
            try
            {
                return expsService.GetExpsInfoByLabRoom(LabRoom);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
