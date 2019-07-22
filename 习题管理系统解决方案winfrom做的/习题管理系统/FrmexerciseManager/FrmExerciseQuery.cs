using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 习题管理系统.FrmexerciseManager
{
    public partial class FrmExerciseQuery : Form
    {
        ExpsTableManager expsManager = new ExpsTableManager();
        List<ExerciseQuery> exerciseQueryList=null;
        public FrmExerciseQuery()
        {
            InitializeComponent();

            //实验室下拉框初始化
            List<string> labRoomList = new List<string>();
            try
            {
                labRoomList = expsManager.GetLabRoomName();
            }
            catch (Exception)
            {

                MessageBox.Show("操作失败,请检查您的网络是否畅通");
                return;
            }

            if (labRoomList != null && labRoomList.Count > 0)
            {
                this.cbLabRoom.DataSource = labRoomList;
                this.cbLabRoom.SelectedIndex = -1;
                this.cbLabRoom.SelectedIndexChanged += new System.EventHandler(this.cbLabRoom_SelectedIndexChanged);         //动态注册下拉框下标改变事件
            }
        }


        private void cbLabRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.cbLabRoom.Text == null || this.cbLabRoom.Text.Trim().Length == 0)      //安全验证，实验室名称下拉框验证是否为空
            {
                return;
            }
            if (this.cbLabRoom.SelectedIndex == -1)
            {
                return;
            }
            string labRoom = this.cbLabRoom.Text.Trim();                            //实验室的名称
            if (labRoom.Trim().Length == 0)
            {
                return;
            }
            List<ExpsTable> expsList = new List<ExpsTable>();                       //存储实验信息的集合

            try
            {
                expsList = expsManager.GetExpsInfoByLabRoom(labRoom);
                if (expsList != null && expsList.Count > 0)
                {

                    this.cbChooseExperiment.DataSource = null;              //实验名称下拉框清空
                    this.cbChooseExperiment.DataSource = expsList;          //绑定数据
                    this.cbChooseExperiment.DisplayMember = "ExpName";
                    this.cbChooseExperiment.ValueMember = "SceneName";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("请检查您的网络是否畅通");
                return;
            }
        }


        

        private void btnQuery_Click(object sender, EventArgs e)
        {
            #region 数据验证
            if (this.cbLabRoom.Text == null || this.cbLabRoom.Text.Trim().Length == 0)      //安全验证，实验室名称下拉框验证是否为空
            {
                return;
            }
            if (this.cbLabRoom.SelectedIndex == -1)
            {
                return;
            }

            if (this.cbChooseExperiment.Text == null || this.cbChooseExperiment.Text.Trim().Length == 0)      //安全验证，实验名称下拉框验证是否为空
            {
                return;
            }
            if (this.cbChooseExperiment.SelectedIndex == -1)
            {
                return;
            }
            #endregion


            string sceneName = this.cbChooseExperiment.SelectedValue.ToString();            //实验场景名称
           

            string teacherName = Program.teacherInfo.teacherName;                         

            if (teacherName == null || teacherName.Length == 0)
            {
                MessageBox.Show("操作非法，请重新登录再操作", "非法提示");
                return;
            }

            ExerciseQuery exerciseQuery = new ExerciseQuery();
            exerciseQuery.sceneName = sceneName;
           
            

            exerciseQueryList = new List<ExerciseQuery>();

            try
            {
                exerciseQueryList = new ExerciseQueryServiceManager().GetExerciseQueryInfoBySceneName(exerciseQuery);

            }
            catch (Exception ex)
            {

                MessageBox.Show("查询失败"+ex.Message, "查询提示");
                return;
            }

            //绑定数据源

            this.dgvInfo.DataSource = null;                 //先清空上一次的数据
            this.dgvInfo.AutoGenerateColumns = false;
            if (exerciseQueryList != null && exerciseQueryList.Count > 0)
            {
                this.dgvInfo.DataSource = exerciseQueryList;

            }
        }

        #region  查看详细信息
        private void btnDetail_Click(object sender, EventArgs e)
        {
            
            if(this.dgvInfo.CurrentRow==null)
            {
                MessageBox.Show("请选择单元格的某个习题", "提示信息");          //安全校验
                return;
            }
            if(exerciseQueryList==null||exerciseQueryList.Count==0)
            {
                return;
            }
            string id = dgvInfo.CurrentRow.Cells["id"].Value.ToString();
            string questonTypeName = dgvInfo.CurrentRow.Cells["questonTypeName"].Value.ToString();
            if(id==null||id.Length==0)
            {
                return;
            }

            //打开选择题详细信息窗口
            if (questonTypeName.Length > 0 && questonTypeName == "单选题")
            {
                ChoiceQuestion choiceQuestionObj = new ChoiceQuestion();
                try
                {
                    choiceQuestionObj = new ChoiceQuestionManager().GetChoiceQuestionInfoById(id);
                }
                catch (Exception)
                {

                    MessageBox.Show("查询失败,请检查您的网络是否畅通", "查询提示");
                    return;
                }

                if (choiceQuestionObj != null)
                {
                    //打开详细信息的窗体
                    FrmChooseQuestionInfo chooseQuestonInfo = new FrmChooseQuestionInfo(choiceQuestionObj);
                    chooseQuestonInfo.ShowDialog();
                }
            }
            else if (questonTypeName.Length > 0 && questonTypeName == "填空题")
            {
                CompletionQuestion completionQuestionObj = new CompletionQuestion();
                try
                {
                    completionQuestionObj = new CompletionQuestionManager().GetCompletionQuestionInfoById(id);
                }
                catch (Exception)
                {

                    MessageBox.Show("查询失败,请检查您的网络是否畅通", "查询提示");
                    return;
                }

                if (completionQuestionObj!= null)
                {
                    //打开对应详细信息的窗体
                    FrmCompletionQuestionInfo completionQuestonInfo = new FrmCompletionQuestionInfo(completionQuestionObj);
                    completionQuestonInfo.ShowDialog();
                }
            }
            else if (questonTypeName.Length > 0 && questonTypeName == "简答题")
            {
                ShortAnswerQuestion shortAnswerQuestionObj = new ShortAnswerQuestion();
                try
                {
                    shortAnswerQuestionObj = new ShortAnswerQuestionManager().GetShortAnswerQuestionInfoById(id);
                }
                catch (Exception)
                {

                    MessageBox.Show("查询失败,请检查您的网络是否畅通", "查询提示");
                    return;
                }

                if (shortAnswerQuestionObj != null)
                {
                    //打开详细信息的窗体
                    FrmShortAnswerQuestionInfo shortAnswerQuestonInfo = new FrmShortAnswerQuestionInfo(shortAnswerQuestionObj);
                    shortAnswerQuestonInfo.ShowDialog();
                }
            }

            
        }
        #endregion

        #region 关闭窗口
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 打开修改实验窗体
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (this.dgvInfo.CurrentRow == null)
            {
                MessageBox.Show("请选择单元格的某个习题", "提示信息");          //安全校验
                return;
            }
            if (exerciseQueryList == null || exerciseQueryList.Count == 0)
            {
                return;
            }
            string id = dgvInfo.CurrentRow.Cells["id"].Value.ToString();
            string questonTypeName = dgvInfo.CurrentRow.Cells["questonTypeName"].Value.ToString();
            if (id == null || id.Length == 0)
            {
                return;
            }

            //打开选择题修改窗口
            if (questonTypeName.Length > 0 && questonTypeName == "单选题")
            {
                ChoiceQuestion choiceQuestionObj = new ChoiceQuestion();
                try
                {
                    choiceQuestionObj = new ChoiceQuestionManager().GetChoiceQuestionInfoById(id);      //通过id获取当前id号对应的选择题详细信息
                    choiceQuestionObj.labRoom = this.cbLabRoom.Text;                                    //把所属的实验室名称也封装上
                    choiceQuestionObj.id = Convert.ToInt32(id);                                                        //把题目编号id也封装上
                }
                catch (Exception)
                {

                    MessageBox.Show("查询失败,请检查您的网络是否畅通", "查询提示");
                    return;
                }

                if (choiceQuestionObj != null)
                {
                    //打开修改信息的窗体
                    FrmModifyChooseQuestion modifyChooseQueston = new FrmModifyChooseQuestion(choiceQuestionObj);
                    DialogResult modifyResult=modifyChooseQueston.ShowDialog();

                    if (modifyResult == DialogResult.OK)    //修改成功，刷新页面
                    {
                        btnQuery_Click(null, null);         //调用一下查询按钮的点击事件即可
                    }
                }
            }
            else if (questonTypeName.Length > 0 && questonTypeName == "填空题")
            {
                CompletionQuestion completionQuestionObj = new CompletionQuestion();
                try
                {
                    completionQuestionObj = new CompletionQuestionManager().GetCompletionQuestionInfoById(id);      //通过id获取当前id号对应的选择题详细信息
                    completionQuestionObj.labRoom = this.cbLabRoom.Text;                                            //把所属的实验室名称也封装上
                    completionQuestionObj.id = Convert.ToInt32(id);                                                        //把题目编号id也封装上
                }
                catch (Exception)
                {

                    MessageBox.Show("查询失败,请检查您的网络是否畅通", "查询提示");
                    return;
                }

                if (completionQuestionObj != null)
                {
                    //打开修改信息的窗体
                    FrmModifyCompletionQuestion modifyChooseQueston = new FrmModifyCompletionQuestion(completionQuestionObj);
                    DialogResult modifyResult = modifyChooseQueston.ShowDialog();

                    if (modifyResult == DialogResult.OK)    //修改成功，刷新页面
                    {
                        btnQuery_Click(null, null);         //调用一下查询按钮的点击事件即可
                    }
                }
            }
            else if (questonTypeName.Length > 0 && questonTypeName == "简答题")
            {
                ShortAnswerQuestion shortAnswerQuestionObj = new ShortAnswerQuestion();
                try
                {
                    shortAnswerQuestionObj = new ShortAnswerQuestionManager().GetShortAnswerQuestionInfoById(id);      //通过id获取当前id号对应的选择题详细信息
                    shortAnswerQuestionObj.labRoom = this.cbLabRoom.Text;                                            //把所属的实验室名称也封装上
                    shortAnswerQuestionObj.id = Convert.ToInt32(id);                                                        //把题目编号id也封装上
                }
                catch (Exception)
                {

                    MessageBox.Show("查询失败,请检查您的网络是否畅通", "查询提示");
                    return;
                }

                if (shortAnswerQuestionObj != null)
                {
                    //打开修改信息的窗体
                    FrmModifyShortAnswerQuestion modifyshortQuestion = new FrmModifyShortAnswerQuestion(shortAnswerQuestionObj);
                    DialogResult modifyResult = modifyshortQuestion.ShowDialog();

                    if (modifyResult == DialogResult.OK)    //修改成功，刷新页面
                    {
                        btnQuery_Click(null, null);         //调用一下查询按钮的点击事件即可
                    }
                }
            }
        }
        #endregion

        #region 删除习题
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvInfo.CurrentRow == null)
            {
                MessageBox.Show("请选择单元格的某个习题", "提示信息");          //安全校验
                return;
            }
            if (exerciseQueryList == null || exerciseQueryList.Count == 0)
            {
                return;
            }
            string id = dgvInfo.CurrentRow.Cells["id"].Value.ToString();
            string questonTypeName = dgvInfo.CurrentRow.Cells["questonTypeName"].Value.ToString();
            if (id == null || id.Length == 0)
            {
                return;
            }

            DialogResult conformResult=MessageBox.Show("确定删除编号为  "+id+"  的题目吗?","删除提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (conformResult != DialogResult.OK)
            {
                return;
            }
            if (questonTypeName.Length > 0 && questonTypeName == "单选题")
            {
                int deleteResult = 0;                   //记录删除结果
                try
                {
                    deleteResult = new ChoiceQuestionManager().DeleteChoiceQuestion(id);
                }
                catch (Exception)
                {

                    MessageBox.Show("网络异常，删除失败");
                    return;
                }
                if (deleteResult > 0)
                {
                    btnQuery_Click(null, null);     //删除成功，调用查询按钮的点击事件刷新修改后的显示结果
                }
                else
                {
                    MessageBox.Show("网络异常，删除失败");
                    return;
                }
            }
            else if (questonTypeName.Length > 0 && questonTypeName == "填空题")
            {
                int deleteResult = 0;                   //记录删除结果
                try
                {
                    deleteResult = new CompletionQuestionManager().DeleteCompletionQuestion(id);
                }
                catch (Exception)
                {

                    MessageBox.Show("网络异常，删除失败");
                    return;
                }
                if (deleteResult > 0)
                {
                    btnQuery_Click(null, null);     //删除成功，调用查询按钮的点击事件刷新修改后的显示结果
                }
                else
                {
                    MessageBox.Show("网络异常，删除失败");
                    return;
                }
            }
            else if (questonTypeName.Length > 0 && questonTypeName == "简答题")
            {
                int deleteResult = 0;                   //记录删除结果
                try
                {
                    deleteResult = new ShortAnswerQuestionManager().DeleteShortAnswerQuestion(id);
                }
                catch (Exception)
                {

                    MessageBox.Show("网络异常，删除失败");
                    return;
                }
                if (deleteResult > 0)
                {
                    btnQuery_Click(null, null);     //删除成功，调用查询按钮的点击事件刷新修改后的显示结果
                }
                else
                {
                    MessageBox.Show("网络异常，删除失败");
                    return;
                }
            }

        }
        #endregion
    }
}
