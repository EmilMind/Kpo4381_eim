﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381.eim.Lib
{
    public enum LoadStatus
    {
        None = 0,
        Success = 1,
        Reading =2,
        FileNameIsEmpty = -1,
        FileNotExists = -2,
        GeneralError = -100
    }
    public class OfficePacksListSplitFileLoader : IOfficePacksListLoader
    {

        private readonly string _dataFileName = "";
        private List<OfficePacks> _officePacksList = null;
        private LoadStatus _status = LoadStatus.None;

        public List<OfficePacks> officePacksList
        {
            get { return _officePacksList; }
        }
        public LoadStatus status
        {
            get { return _status; }
        }
        //     public SearchProjectListSplitFileLoader(string dataFileName)
        //     {
        //       _dataFileName = dataFileName;
        //         _searchProjectList = new List<SearchProject>();
        //     }
        public OfficePacksListSplitFileLoader(string dataFileName)
        {
            _dataFileName = dataFileName;
            _officePacksList = new List<OfficePacks>();
        }

        public void Execute()
        {
            _status = LoadStatus.Reading;

            if (_dataFileName == "")
            {

                _status = LoadStatus.FileNameIsEmpty;
                throw new Exception("Имя файла отсутствует");

            }
            if (!File.Exists(_dataFileName))
            {

                _status = LoadStatus.FileNotExists;
                throw new FileNotFoundException();
            }


            StreamReader sr = null;
            using (sr = new StreamReader(_dataFileName))
            {
                while (!sr.EndOfStream)
                {
                    try
                    {
                        string str = sr.ReadLine();
                        string[] arr = str.Split('|');
                        OfficePacks newOfficePacks = new OfficePacks()
                        {
                            name = arr[0],
                            vendor = arr[1],
                            composition = Convert.ToInt32(arr[2]),
                            price = Convert.ToInt32(arr[3])
                        };
                        _officePacksList.Add(newOfficePacks);
                    }
                    catch (Exception ex)
                    {
                        LogUtility.ErrorLog(ex);
                        _status = LoadStatus.GeneralError;
                    }

                }
            }
            _status = LoadStatus.Success;
        }
    }
}