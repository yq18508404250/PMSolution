﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functions.Model
{
    public static class ItemCollection
    {
        /// <summary>
        /// 包装机异型烟链板机数据写入DB块 5个
        /// </summary>
        /// <returns></returns>
        public static List<string> GetTaskStatusBySend_yxy()  //8个
        {
            string S7Name = PubFunction.GlobalPara.Opc_Nameyxy;
            List<string> list = new List<string>();
            list.Add(S7Name + "DB3,DINT0");//包号  0
            list.Add(S7Name + "DB3,W4");//数量 1
            list.Add(S7Name + "DB3,W6");//合包标志 2
            list.Add(S7Name + "DB3,W8");//合包数量 3
            list.Add(S7Name + "DB3,W12");//推烟位置（层数） 4
            list.Add(S7Name + "DB3,DINT14");//预留  5
            list.Add(S7Name + "DB3,W18");//预留  6
            list.Add(S7Name + "DB3,W20");//交互标志  7
            return list;
        }

        /// <summary>
        /// 包装机异型烟链板机完成信号的DB块 10个
        /// </summary>
        /// <returns></returns>
        public static List<string> GetTaskStatusByComplete_yxy()  //10个
        {
            string S7Name = PubFunction.GlobalPara.Opc_Nameyxy;
            List<string> list = new List<string>();
            for (int i = 0; i < 40; i += 4)
            {
                list.Add(S7Name + "DB30,DINT" + i);
            }
            return list;
        }
        /// <summary>
        /// 包装机常规烟翻板机数据写入DB块  --7个
        /// </summary>
        /// <returns></returns>
        public static List<string> GetTaskStatusBySend_cgy()
        {
            string S7Name = PubFunction.GlobalPara.Opc_Namecgy;
            List<string> list = new List<string>();
            list.Add(S7Name + "DB30,DINT500");//整包任务号
            list.Add(S7Name + "DB30,W504");//包内烟条数
            list.Add(S7Name + "DB30,W506");//合包标志
            list.Add(S7Name + "DB30,WT508");//合包数量
            list.Add(S7Name + "DB30,DINT510");//预留
            list.Add(S7Name + "DB30,W514");//预留
            list.Add(S7Name + "DB30,W516");//接收标志

            return list;
        }
        /// <summary>
        /// 包装机常规烟翻板机完成信号的DB块  --10个
        /// </summary>
        /// <returns></returns>
        public static List<string> GetTaskStatusByComplete_cgy()
        {
            string S7Name = PubFunction.GlobalPara.Opc_Namecgy;//10个
            List<string> list = new List<string>();
            for (int i = 0; i < 40; i += 4)
            {
                list.Add(S7Name + "DB30,W" + 530 + i * 4);
            }
            return list;
        }

        /// <summary>
        /// 获取异形烟缓存工位信息
        /// </summary>
        /// <returns></returns>
        public static List<string> GetUnNormalWorkPlaceItem()
        {
            string S7Name = PubFunction.GlobalPara.Opc_Nameyxy;
            List<string> list = new List<string>();
            for (int i = 0; i < 7; i++)
            {
                list.Add(S7Name + "DB30,DINT"+ (i *12));//包号
                list.Add(S7Name + "DB30,INT" +( 4 + (i * 12)));//数量
                list.Add(S7Name + "DB30,INT" + (6 + (i * 12)));//合单标志
                list.Add(S7Name + "DB30,INT" + (8 + (i * 12)));//推烟位置
                list.Add(S7Name + "DB30,INT" +( 10 + (i * 12)));//顺序标志
            } 
            return list;
        }

        public static List<string> ClearAndStop_cgy()
        {
            string S7Name = PubFunction.GlobalPara.Opc_Nameyxy;
            List<string> list = new List<string>();
            list.Add(S7Name + "DB30,W518");//清空任务
            list.Add(S7Name + "DB30,W520");//停止设备运行
            return list;
        }

        public static List<string> ClearAndStop_yxy()
        {
            string S7Name = PubFunction.GlobalPara.Opc_Nameyxy;
            List<string> list = new List<string>();
            
            return list;
        }
        public static List<string> newFuc()
        {
            List<string> list = new List<string>();
            list.Add("DB3.DINT0");
            list.Add("DB3.W4");


            list.Add("DB3.W6");
            list.Add("DB3.W8");
            list.Add("DB3.W12");


            list.Add("DB3.DINT14");
            list.Add("DB3.W18");
            list.Add("DB3.W20");




            return list;
        }
        public static List<string> newFuc2()
        {
             
            List<string> list = new List<string>();
            list.Add("DB30.DINT0");


            list.Add("DB30.W4");
            list.Add("DB30.W6");
            list.Add("DB30.W8");


            list.Add("DB30.W10");
            return list;
        }
    }
}
