﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Pharmacy.Implement.Utils.DatabaseManager.QueryAction.MedicineManagement
{
    public class GetAllMedicineUnitDataAction : AbstractQueryAction
    {
        public GetAllMedicineUnitDataAction()
        {
            _action = GetAllMedicineUnitData;
        }

        private SQLQueryResult GetAllMedicineUnitData(PharmacyDBContext appDBContext, object[] paramaters)
        {
            SQLQueryResult result = new SQLQueryResult(null, MessageQueryResult.Non);
            try
            {
                List<tblMedicineUnit> lstOutput = appDBContext.tblMedicineUnits.ToList();
                result = new SQLQueryResult(lstOutput, MessageQueryResult.Done);
            }
            catch (Exception e)
            {
                App.Current.ShowApplicationMessageBox(e.Message);
                result = new SQLQueryResult(null, MessageQueryResult.Aborted);
            }
            return result;
        }
    }
}
