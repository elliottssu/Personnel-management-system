using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 企业人事管理系统
{
    class Employee
    {
        int id;
        string name;
        string ename;
        int age;
        string sex;
        DateTime chusheng;
        string jiguan;
        string xianzhi;
        string tel;
        string hander;
        DateTime jingongsi;
        string zhengshi;
        string hetong;
        string qixian;
        DateTime youxiaoqi;
        string zhiwei;
        string suoshu;
        string kong;
        string email;
        string xueli;
        string school;
        string zhuanye;
        string mianmao;
        string hun;
        string work;
        DateTime uj;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Ename
        {
            get { return ename; }
            set { ename = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public DateTime Chusheng
        {
            get { return chusheng; }
            set { chusheng = value; }
        }
        public string Jiguan
        {
            get { return jiguan; }
            set { jiguan = value; }
        }
        public string Xianzhi
        {
            get { return xianzhi; }
            set { xianzhi = value; }
        }
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        public string Hander
        {
            get { return hander; }
            set { hander = value; }
        }
        public DateTime Jingongsi
        {
            get { return jingongsi; }
            set { jingongsi = value; }
        }
        public string Zhengshi
        {
            get { return zhengshi; }
            set { zhengshi = value; }
        }
        public string Hetong
        {
            get { return hetong; }
            set { hetong = value; }
        }
        public string Qixian
        {
            get { return qixian; }
            set { qixian = value; }
        }
        public DateTime Youxianqi
        {
            get { return youxiaoqi; }
            set { youxiaoqi = value; }
        }
        public string Zhiwei
        {
            get { return zhiwei; }
            set { zhiwei = value; }
        }
        public string Suoshu
        {
            get { return suoshu; }
            set { suoshu = value; }
        }
        public string Kong
        {
            get { return kong; }
            set { kong = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Xueli
        {
            get { return xueli; }
            set { xueli = value; }
        }
        public string School
        {
            get { return school; }
            set { school = value; }
        }
        public string Zhuanye
        {
            get { return zhuanye; }
            set { zhuanye = value; }
        }
        public string Mianmao
        {
            get { return mianmao; }
            set { mianmao = value; }
        }
        public string Hun
        {
            get { return hun; }
            set { hun = value; }
        }
        public string Work
        {
            get { return work; }
            set { work = value; }
        }
        public DateTime Uj
        {
            get { return uj; }
            set { uj = value; }
        }
        public void Insert()         //添加员工信息
        {
            string sql = string.Format("Insert Into Employee Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}')", id, name, ename, age, sex, chusheng, jiguan, xianzhi, tel, hander, jingongsi, zhengshi, hetong, qixian, youxiaoqi, zhiwei, suoshu, kong, email, xueli, school, zhuanye, mianmao, hun, work, uj);
        
        }
        public void Update(int id)   //修改学生信息
        {
            string sql = String.Format("Update Employee set name='{0}',ename='{1}',age='{2}',sex='{3}',chusheng='{4}',jiguan='{5}',xianzhi='{6}',tel='{7}',hander='{8}',jingongsi='{9}',zhengshi='{10}',hetong='{11}',qixian='{12}',youxiaoqi='{13}',zhiwei='{14}',suoshu='{15}',kong='{16}',email='{17}',xueli='{18',school='{19}',zhuanye='{20}',mianmao='{21}',hun='{22}',work='{23}'uj='{24}'where id='{25}'", name, ename, age, sex, chusheng, jiguan, xianzhi, tel, hander, jingongsi, zhengshi, hetong, qixian, youxiaoqi, zhiwei, suoshu, kong, email, xueli, school, zhuanye, mianmao, hun, work, uj, id);
            
        }
        public void Delete()        //删除学生信息
        {
            string sql = String.Format("Delete Form Employee Where id='{0}'", id);
     
        }
    }
}
