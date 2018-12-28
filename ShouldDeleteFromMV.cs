
using System;
using Microsoft.MetadirectoryServices;

namespace Mms_Metaverse
{
    /// <summary>
    /// Summary description for MVExtensionObject.
    /// </summary>
    public partial class MVExtensionObject
    {


        bool IMVSynchronization.ShouldDeleteFromMV(CSEntry csentry, MVEntry mventry)
        {
            //
            // TODO: Add MV deletion logic here
            //
            throw new EntryPointNotImplementedException();
        }
    }
}