using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.BL.Model;
using Demo.DAL.Database;
using Demo.DAL.Etinties;


namespace Demo.BL.Interface
{
    public interface IFunctions
    {
        //Sync
        #region Sync

        //#region send data to database
        //void Create(StudentVM obj);

        //#endregion

        //#region Retrieve All Data
        //void GetAllData();

        //#endregion

        //#region Retrieve Student Data By Id
        //void GetDataById(int id);

        //#endregion

        //#region Update Data
        //void Update(int id, StudentVM obj);
        //#endregion
        //#region DeleteAllData By Id

        //void DeleteById(int id);

        //#endregion
        //#region CheckData
        //bool CheckData(int id);
        //#endregion
        #endregion


        //----------------------------------\\

        //Async
        #region Async
        #region send data to database
        Task Create(StudentVM obj);

        #endregion

        #region Retrieve All Data
        Task GetAllData();

        #endregion

        #region Retrieve Student Data By Id
        Task GetDataById(int id);

        #endregion

        #region Update Data
        Task Update(int id, StudentVM obj);
        #endregion
        #region DeleteAllData By Id

        Task  DeleteById(int id);

        #endregion
        #region CheckData
        Task<bool> CheckData(int id);
        #endregion

        #endregion

    }
}
