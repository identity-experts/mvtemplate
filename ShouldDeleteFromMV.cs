
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
        /// Route Deprovisioning code through here
        /// </summary>
        /// <param name="csentry"></param>
        /// <param name="mventry"></param>
        /// <returns></returns>
        bool IMVSynchronization.ShouldDeleteFromMV(CSEntry csentry, MVEntry mventry)
        {
            switch (mventry.ObjectType.ToUpper())
            {
                case OBJECTCLASS_PERSON: return ShouldDeletePerson(csentry, mventry);
            }

            throw new EntryPointNotImplementedException();
        }

        /// <summary>
        /// Evaluate this object and check to see if it should be removed from the MV or not
        /// return true if it should be removed, false otherwise
        /// </summary>
        /// <param name="csentry"></param>
        /// <param name="mventry"></param>
        private bool ShouldDeletePerson(CSEntry csentry, MVEntry mventry)
        {
            return false;
        }
    }


}