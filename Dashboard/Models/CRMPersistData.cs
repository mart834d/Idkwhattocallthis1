using System;

using System.ComponentModel.DataAnnotations;



namespace SeasNve.Common.Model.PersistData

{

    public class CRMPersistData

    {

        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required()]

        public string SerializedObject { get; set; }

        public bool TransferOk { get; set; }

        public string ErrorMessage { get; set; }

        public DateTime? TransferDate { get; set; }

        public string ExceptionMessage { get; set; }

        [Required()]

        public int ErrorCount { get; set; }

        public string TransactionId { get; set; }

        [Required()]

        public string DataType { get; set; }

        [Required()]

        public bool InProgress { get; set; }

        public string OrderId { get; set; }

    }



    public enum PersistingType

    {
        Unavailable,
        Eltilkendegivelse,
        PowerOrder,
        PowerOrderFlow,
        PowerOrderFlowGas,
        Gas,
        BulkGas,
        Bulk,
        RetentionProductSurveyAnswer,
        RetentionConsumptionSurveyAnswer,
        RetentionContentmentSurveyAnswer,
        RetentionRequestCall,
        RetentionSetCustomProperty,
        ThirdPartyAuthorizationNotification,
        PowerSupplyPurchaseOrder
    };

}