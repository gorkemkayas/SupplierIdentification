using System.Collections.Generic;
using Bimser.Framework;
using Bimser.Framework.Domain;

namespace SupplierIdentification.Helper
{
    public static class Model
    {
        public class HrObject
        {
            public int id { get; set; }
            public string username { get; set; }
            public string firstname { get; set; }
            public string lastname { get; set; }
            public string password { get; set; }
            public string eMail { get; set; }
            public int status { get; set; }
            public int importStatus { get; set; }
            public object birthDate { get; set; }
            public object employementStart { get; set; }
            public object employementEnd { get; set; }
            public int category { get; set; }
            public int sex { get; set; }
            public int type { get; set; }
            public int department { get; set; }
            public int profession { get; set; }
            public string departmentName { get; set; }
            public string professionName { get; set; }
            public object shiftName { get; set; }
            public bool loadDetail { get; set; }
            public object profileImage { get; set; }
            public int usedCount { get; set; }
            public object phone { get; set; }
            public object mobilePhone { get; set; }
            public object registrationNumber { get; set; }
            public object placeOfBirth { get; set; }
            public object identificationNumber { get; set; }
            public object personalEMail { get; set; }
            public object personalMobilePhone { get; set; }
            public object personalPhone { get; set; }
            public object address { get; set; }
            public object shiftId { get; set; }
            public object defaultCulture { get; set; }
        }

        public class UserInsertRequest
        {
            public HrObject hrObject { get; set; }
        }

        public class UserBulkInfo
        {
            public int id { get; set; }
            public int osid { get; set; }
            public int objectId { get; set; }
            public int propertyTypeId { get; set; }
            public int importStatus { get; set; }
            public MultiLanguage value { get; set; }
        }

        public class UserBulkProperties
        {
            public int osid { get; set; }
            public int propertyTypeId { get; set; }
            public int order { get; set; }
            public int isRequired { get; set; }
            public int id { get; set; }
        }

        public class UserBulkPropertyTypes
        {
            public int id { get; set; }
            public int type { get; set; }
            public string @params { get; set; }
            public bool isMLSupport { get; set; }
            public string propertyName { get; set; }
            public MultiLanguage description { get; set; }
            public MultiLanguage caption { get; set; }
            public MultiLanguage defaultValue { get; set; }
        }

        public class PHrObject
        {
            public int osid { get; set; }
            public long objectId { get; set; }
            public int propertyTypeId { get; set; }
            public int importStatus { get; set; }
            public MultiLanguage value { get; set; }
            public int modifyState { get; set; }
        }

        public class BulkObject
        {
            public List<PHrObject> HrObjects { get; set; }
        }
        public class GRHrObject
        {
            public int groupId { get; set; }
            public int userId { get; set; }
        }

        public class GroupContentRequest
        {
            public GRHrObject hrObject { get; set; }
        }

        public class HeaderProperties
        {
            public string EncryptedData { get; set; }
            public string Language { get; set; }
        }
        public class SessionProperties
        {
            public string Token { get; set; }
            public string Language { get; set; }
            public string EncryptedData { get; set; }
        }

        public class BimserException
        {
            public string ClassName { get; set; }
            public string Message { get; set; }
            public object Data { get; set; }
            public BimserException InnerException { get; set; }
            public object HelpURL { get; set; }
            public string StackTraceString { get; set; }
            public object RemoteStackTraceString { get; set; }
            public int RemoteStackIndex { get; set; }
            public object ExceptionMethod { get; set; }
            public int HResult { get; set; }
            public string Source { get; set; }
            public object WatsonBuckets { get; set; }
            public string Code { get; set; }
            public string FootPrint { get; set; }
            public int ExceptionType { get; set; }
            public object ExternalException { get; set; }
        }
        public class BimserExceptionMessage
        {
            public bool success { get; set; }
            public BimserException exception { get; set; }
        }
        public class GetPartnerDetailIdByEmailResponse
        {
            public int DOCUMENTID { get; set; }
            public int CompanyId { get; set; }
        }
    }
}