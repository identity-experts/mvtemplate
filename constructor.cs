
using System;
using Microsoft.MetadirectoryServices;
using NLog;

namespace Mms_Metaverse
{
	/// <summary>
	/// Summary description for MVExtensionObject.
	/// </summary>
    public partial class MVExtensionObject : IMVSynchronization
    {
        //-- enable NLog
        private static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Add any constructor logic in here
        /// </summary>
        public MVExtensionObject()
        {
        }
    }
}
