﻿using Functions.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Functions.PubFunction;
using Functions.Model;
using System.Threading;

namespace PackageMachine
{
    public partial class FmTaskLocate : Form
    {
        public FmTaskLocate()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            rts = new RobotTaskService();
            lblinfo.Text = "提示：定位会从指定的任务重新开始下发任务\r\n并且清空电控（倍速链，翻版，机器人）已缓存的任务数据！ ";
        }
        public Functions.OPC_ToPLC opc { get; set; }
        Group G7;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="shpG7">PLC清空与暂停组</param>
        public FmTaskLocate(Group  shpG7)
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            rts = new RobotTaskService();
            G7 = shpG7;
            lblinfo.Text = "提示：定位会从指定的任务重新开始下发任务\r\n并且清空电控（倍速链，翻版，机器人）已缓存的任务数据！\r\n可选择输入定位，即定位输入的内容。 ";
        }
        private delegate void HandleDelegate1(string info, Label label);
        public void updateLabel(string info, Label label)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(new HandleDelegate1(updateLabel), new Object[] { info, label });
            }
            else
            {
                label.Text = info;

            }
        }
        RobotTaskService rts;
        decimal yxyRobot = 0, yxyCigSeq = 0, cgyFb = 0, yxyBsul = 0;

        private async void btn_clearFB_Click(object sender, EventArgs e)
        {
            //确认调用
            DialogResult MsgBoxResult = MessageBox.Show("确认清空翻板数据？", "提示：请谨慎操作！", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (MsgBoxResult == DialogResult.OK)
            {
                await clearfun.ClearFB(opc);
            }
        }

        PLCDataClear clearfun = new PLCDataClear();

        private async void btn_clearBSL_Click(object sender, EventArgs e)
        {
            //确认调用
            DialogResult MsgBoxResult = MessageBox.Show("确认清空倍速链数据？","提示：请谨慎操作！",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (MsgBoxResult == DialogResult.OK)
            {
                await clearfun.ClearBSL(opc);
            }
        }

        private void btnDw_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRobot.Text + txtFb.Text + txtBsul.Text))
            {
                return;
            } 
            string info = "";
            if (!string.IsNullOrWhiteSpace(txtFb.Text))
            {
                info += "翻版从" + txtFb.Text + " 包号开始";
                  cgyFb = txtFb.Text.CastTo<decimal>();
            } 
            if (!string.IsNullOrWhiteSpace(txtBsul.Text))
            {
                info += "\r\n倍速链从" + txtBsul.Text + " 包号开始";
                yxyBsul = txtBsul.Text.CastTo<decimal>();
            }
            if (!string.IsNullOrWhiteSpace(txtRobot.Text))
            {
                info += "\r\n异型烟机器人从" + txtRobot.Text + " 包号,第 " + txtCigseq.Text + " 条烟开始";
                  yxyRobot = txtRobot.Text.CastTo<decimal>();
                  yxyCigSeq = txtCigseq.Text.CastTo<decimal>();
            }
            DialogResult MsgBoxResult2 = MessageBox.Show(info,
                                                             "确认定位",
                                                             MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult.OK == MsgBoxResult2)
            {
                FmInfo.GetTaskInfo(info);
                updateLabel("校验输入的包号是否存在...", lblOper);
                if (rts.CheckPackageTaskNum(yxyRobot, yxyCigSeq, cgyFb, yxyBsul, out string errinfo))
                {
                    FmInfo.GetTaskInfo("准备数据库进行定位..."  );
                    updateLabel("准备数据库进行定位...", lblOper);
                    if (rts.TaskLocate(yxyRobot, yxyCigSeq, cgyFb, yxyBsul))
                    {
                        updateLabel("定位成功！", lblOper);
                        FmInfo.GetTaskInfo(info + "定位成功！");
                        MessageBox.Show("定位成功！");
                    }
                    else
                    {
                        updateLabel("定位失败！\r\n数据库改变行数为0！", lblOper);
                        FmInfo.GetTaskInfo(info + "定位失败！\r\n数据库改变行数为0！");
                        MessageBox.Show("定位失败！\r\n数据库改变行数为0！");
                    }
                }
                else
                {
                    FmInfo.GetTaskInfo("任务包号校验未通过：" + errinfo);
                    updateLabel("任务包号校验未通过：" + errinfo, lblOper);
                    MessageBox.Show(errinfo);
                }
                txtFb.Text = "";
                txtBsul.Text = "";
                txtRobot.Text = "";
                txtCigseq.Text = "";

            }
            else
            {
                MessageBox.Show("取消成功！", "任务定位", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


        }
    }
}
