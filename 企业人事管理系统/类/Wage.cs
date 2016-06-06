using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 企业人事管理系统
{
    class Wage
    {
        string id;
        string name;
        DateTime time;
        string rixin;
        string benxin;
        string jiangjin;
        string jiari;
        string quanqin;
        string jiaban;
        string benqi;
        string fuli;
        string huoshi;
        string suode;
        string jiezhi;
        string shifa;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }
        public string Rixin
        {
            get { return rixin; }
            set { rixin = value; }
        }
        public string Benxin
        {
            get { return benxin; }
            set { benxin = value; }
        }
        public string Jiangjin
        {
            get { return jiangjin; }
            set { jiangjin = value; }
        }
        public string Jiari
        {
            get { return jiari; }
            set { jiari = value; }
        }
        public string Quanqin
        {
            get { return quanqin; }
            set { quanqin = value; }
        }
        public string Jiaban
        {
            get { return jiaban; }
            set { jiaban = value; }
        }
        public string Benqi
        {
            get { return benqi; }
            set { benqi = value; }
        }
        public string Fuli
        {
            get { return fuli; }
            set { fuli = value; }
        }
        public string Huoshi
        {
            get { return huoshi; }
            set { huoshi = value; }
        }
        public string Suode
        {
            get { return suode; }
            set { suode = value; }
        }
        public string Jiezhi
        {
            get { return jiezhi; }
            set { jiezhi = value; }
        }
        public string Shifa
        {
            get { return shifa; }
            set { shifa = value; }
        }
        public void Insert()
        {
            string sql = string.Format("Insret Into Wage Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}', '{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')",
                id, name, time, rixin, benxin, jiangjin, jiari, quanqin, jiaban, benqi, fuli, huoshi, suode, jiezhi, shifa);
        
        }
        public void Update(string id)
        {
            string sql = string.Format("Update Wage Set name='{0}',time='{1}',rixin='{2}',benxin='{3}',jiangjin='{4}',jiari='{5}',quanqin='{6}',jiaban='{7}',benqi='{8}',fuli='{9}',huoshi='{10}',suode='{11}',jiezhi='{12}',shifa='{13}',id='{14}'");

        }
    }
}
