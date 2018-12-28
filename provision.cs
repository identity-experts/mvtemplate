
using System;
using Microsoft.MetadirectoryServices;

namespace Mms_Metaverse
{
    /// <summary>
    /// Summary description for MVExtensionObject.
    /// </summary>
    public partial class MVExtensionObject
    {

        /// <summary>
        /// Provisioning - use this only for routing out to individual methods for each object class
        /// 
        /// don't forget to use constants instead of "magic strings" 
        /// </summary>
        /// <param name="mventry"></param>
        void IMVSynchronization.Provision(MVEntry mventry)
        {
            switch (mventry.ObjectType.ToUpper())
            {
                case OBJECTCLASS_PERSON:    ProvisionPerson(mventry); break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Handle all provisioning decisions for Person objects
        /// </summary>
        /// <param name="mventry"></param>
        private void ProvisionPerson(MVEntry mventry)
        {
            //-- make all decisions about provisioning here
            //-- then call individual methods for each target system
            bool provision_to_AD = false;

            if (provision_to_AD)
                ProvisionPersonToAD(mventry);

        }

        /// <summary>
        /// Provisioning code to create a new person in AD
        /// </summary>
        /// <param name="mventry"></param>
        private void ProvisionPersonToAD(MVEntry mventry)
        {

        }
    }
}