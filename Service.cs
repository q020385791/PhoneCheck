using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCheck
{
    public class Service
    {
        public List<Model> GetlsPhone() 
        {
            List<Model> result = new List<Model>();
            string FilePath = Path.Combine(Environment.CurrentDirectory, "Phonelist.txt");
            using (StreamReader source = File.OpenText(FilePath))
            {
                JsonSerializer Serializer = new JsonSerializer();
                 result = (List<Model>)Serializer.Deserialize(source, typeof(List<Model>));
            }
            return result;
        }


        public List<Model> GetGetlsPhone(string DepKeyword, string RoomKeyword) 
        {
            List<Model> _model = new List<Model>();
            if (RoomKeyword.Trim() == "" && DepKeyword.Trim() == "")
            {
                return _model;
            }

            if (RoomKeyword.Trim() == ""&& DepKeyword.Trim()!="")
            {
                _model=GetlsPhoneByDep(DepKeyword);
            }else if (RoomKeyword.Trim() != "" && DepKeyword.Trim() == "") 
            {
                _model = GetlsPhoneByRoom(RoomKeyword);
            }else if (RoomKeyword.Trim() != "" && DepKeyword.Trim() != "") 
            {
                _model = GetlsPhoneByDepAndRoom(DepKeyword,RoomKeyword);
            }
            return _model;
        }

        public List<Model> GetlsPhoneByDep(string DepKeyword) 
        {
            List<Model> result = new List<Model>();
            List<Model> AModel = GetlsPhone();
            foreach (Model _model in AModel)
            {
                if (_model.Dep.Contains(DepKeyword))
                {
                    result.Add(_model);
                }
            }
            return result;
        }

        public List<Model> GetlsPhoneByRoom(string RoomKeyword) 
        {
            List<Model> result = new List<Model>();
            List<Model> AModel = GetlsPhone();
           
            foreach (Model _model in AModel)
            {
                bool IFexist = false;
                Model Temp = new Model();
                Temp.Dep = _model.Dep;
                Temp.lsUnit = new List<Unit>();
                foreach (Unit _unit in _model.lsUnit)
                {
                    Unit TempUnit = new Unit();
                    if (_unit.Name.Contains(RoomKeyword))
                    {
                        Temp.lsUnit.Add(_unit);
                        IFexist = true;
                        continue;
                    }
                }
                //如果有存在相關名稱才加入
                if (IFexist)
                {
                    result.Add(Temp);
                }
            }

            return result;
        }



        public List<Model> GetlsPhoneByDepAndRoom(string DepKeyword, string RoomKeyword) 
        {
            List<Model> result = new List<Model>();
            List<Model> AModel = GetlsPhone();

            foreach (Model _model in AModel)
            {
                if (_model.Dep.Contains(DepKeyword))
                {
                    bool IFexist = false;
                    Model Temp = new Model();
                    Temp.Dep = _model.Dep;
                    Temp.lsUnit = new List<Unit>();
                    foreach (Unit _unit in _model.lsUnit)
                    {
                        Unit TempUnit = new Unit();
                        if (_unit.Name.Contains(RoomKeyword))
                        {
                            Temp.lsUnit.Add(_unit);
                            IFexist = true;
                            continue;
                        }
                    }
                    //如果有存在相關名稱才加入
                    if (IFexist)
                    {
                        result.Add(Temp);
                    }
                }
               
            }
            return result;
        }

        public string SampleObjectToJson() 
        {
            string result = "";
            List<Model> lsmodel = new List<Model>();
            for (int i = 0; i < 3; i++)
            {
                Model Temp = new Model();
                Temp.Dep = "Dep" + i.ToString();
                Temp.lsUnit = new List<Unit>();
                for (int j = 0; j < 3; j++)
                {
                    Unit _TempUnit = new Unit();
                    _TempUnit.Name = ("Unit" + j.ToString());
                    _TempUnit.Phones = "123,456".Split(',').ToList();
                    Temp.lsUnit.Add(_TempUnit);
                }
                lsmodel.Add(Temp);
            }

            result = JsonConvert.SerializeObject(lsmodel);
            return result;
        }
    }

   
}
