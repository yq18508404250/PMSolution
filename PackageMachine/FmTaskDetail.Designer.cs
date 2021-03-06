﻿namespace PackageMachine
{
    partial class FmTaskDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmTaskDetail));
            this.lblcheck = new System.Windows.Forms.Label();
            this.cbIsorNo = new System.Windows.Forms.CheckBox();
            this.list_date = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listCgy = new System.Windows.Forms.ListBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcheck
            // 
            this.lblcheck.AutoSize = true;
            this.lblcheck.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblcheck.Location = new System.Drawing.Point(12, 9);
            this.lblcheck.Name = "lblcheck";
            this.lblcheck.Size = new System.Drawing.Size(114, 20);
            this.lblcheck.TabIndex = 2;
            this.lblcheck.Text = "保持前端显示：";
            // 
            // cbIsorNo
            // 
            this.cbIsorNo.AutoSize = true;
            this.cbIsorNo.Location = new System.Drawing.Point(126, 15);
            this.cbIsorNo.Name = "cbIsorNo";
            this.cbIsorNo.Size = new System.Drawing.Size(15, 14);
            this.cbIsorNo.TabIndex = 3;
            this.cbIsorNo.UseVisualStyleBackColor = true;
            this.cbIsorNo.Click += new System.EventHandler(this.cbIsorNo_Click);
            // 
            // list_date
            // 
            this.list_date.BackColor = System.Drawing.SystemColors.Control;
            this.list_date.Dock = System.Windows.Forms.DockStyle.Left;
            this.list_date.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.list_date.FormattingEnabled = true;
            this.list_date.ItemHeight = 17;
            this.list_date.Location = new System.Drawing.Point(0, 0);
            this.list_date.Name = "list_date";
            this.list_date.Size = new System.Drawing.Size(396, 359);
            this.list_date.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listCgy);
            this.panel1.Controls.Add(this.list_date);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 359);
            this.panel1.TabIndex = 5;
            // 
            // listCgy
            // 
            this.listCgy.BackColor = System.Drawing.SystemColors.Control;
            this.listCgy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCgy.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listCgy.FormattingEnabled = true;
            this.listCgy.ItemHeight = 17;
            this.listCgy.Location = new System.Drawing.Point(396, 0);
            this.listCgy.Name = "listCgy";
            this.listCgy.Size = new System.Drawing.Size(449, 359);
            this.listCgy.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl1.Location = new System.Drawing.Point(4, 78);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(159, 20);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "异型烟倍速链任务信息";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl2.Location = new System.Drawing.Point(395, 78);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(204, 20);
            this.lbl2.TabIndex = 6;
            this.lbl2.Text = "常规烟翻板、机器人任务信息";
            // 
            // FmTaskDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 460);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbIsorNo);
            this.Controls.Add(this.lblcheck);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmTaskDetail";
            this.Text = "任务详情";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmTaskDetail_FormClosing);
            this.Load += new System.EventHandler(this.FmTaskDetail_Load);
            this.SizeChanged += new System.EventHandler(this.FmTaskDetail_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblcheck;
        private System.Windows.Forms.CheckBox cbIsorNo;
        private System.Windows.Forms.ListBox list_date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listCgy;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
    }
}