﻿using GettingStarted_UST;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace GettingStarted_UST
{
    internal interface IWebDriverSpec
    {
        /*
       New Session
       Delete Session
GET	/status Status
GET	/session/{session id}/ timeouts  Get Timeouts
POST	/session/{session id}/ timeouts  Set Timeouts
POST	/session/{session id}/ url   Navigate To
GET	/session/{session id}/ url   Get Current URL
POST	/session/{session id}/ back  Back
POST	/session/{session id}/ forward   Forward
POST	/session/{session id}/ refresh   Refresh
GET	/session/{session id}/ title Get Title
GET	/session/{session id}/ window    Get Window Handle
DELETE	/session/{session id}/ window    Close Window
POST	/session/{session id}/ window    Switch To Window
GET	/session/{session id}/ window / handles    Get Window Handles
POST	/session/{session id}/ window / new New Window
POST	/session/{session id}/ frame Switch To Frame
POST	/session/{session id}/ frame / parent  Switch To Parent Frame
GET	/session/{session id}/ window / rect   Get Window Rect
POST	/session/{session id}/ window / rect   Set Window Rect
POST	/session/{session id}/ window / maximize   Maximize Window
POST	/session/{session id}/ window / minimize   Minimize Window
POST	/session/{session id}/ window / fullscreen Fullscreen Window
GET	/session/{session id}/ element / active    Get Active Element
GET	/session/{session id}/ element /{ element id}/ shadow   Get Element Shadow Root
POST	/session/{session id}/ element   Find Element
POST	/session/{session id}/ elements  Find Elements
POST	/session/{session id}/ element /{ element id}/ element  Find Element From Element
POST	/session/{session id}/ element /{ element id}/ elements Find Elements From Element
POST	/session/{session id}/ shadow /{ shadow id}/ element    Find Element From Shadow Root
POST	/session/{session id}/ shadow /{ shadow id}/ elements   Find Elements From Shadow Root
GET	/session/{session id}/ element /{ element id}/ selected Is Element Selected
GET	/session/{session id}/ element /{ element id}/ attribute /{ name}
Get Element Attribute
GET	/session/{session id}/ element /{ element id}/ property /{ name}
Get Element Property
GET	/session/{session id}/ element /{ element id}/ css /{ property name}
Get Element CSS Value
GET	/session/{session id}/ element /{ element id}/ text Get Element Text
GET	/session/{session id}/ element /{ element id}/ name Get Element Tag Name
GET	/session/{session id}/ element /{ element id}/ rect Get Element Rect
GET	/session/{session id}/ element /{ element id}/ enabled  Is Element Enabled
GET	/session/{session id}/ element /{ element id}/ computedrole Get Computed Role
GET	/session/{session id}/ element /{ element id}/ computedlabel    Get Computed Label
POST	/session/{session id}/ element /{ element id}/ click    Element Click
POST	/session/{session id}/ element /{ element id}/ clear    Element Clear
POST	/session/{session id}/ element /{ element id}/ value    Element Send Keys
GET	/session/{session id}/ source    Get Page Source
POST	/session/{session id}/ execute / sync  Execute Script
POST	/session/{session id}/ execute / async Execute Async Script
GET	/session/{session id}/ cookie    Get All Cookies
GET	/session/{session id}/ cookie /{ name}
Get Named Cookie
POST	/session/{session id}/ cookie    Add Cookie
DELETE	/session/{session id}/ cookie /{ name}
Delete Cookie
DELETE	/session/{session id}/ cookie    Delete All Cookies
POST	/session/{session id}/ actions   Perform Actions
DELETE	/session/{session id}/ actions   Release Actions
POST	/session/{session id}/ alert / dismiss Dismiss Alert
POST	/session/{session id}/ alert / accept  Accept Alert
GET	/session/{session id}/ alert / text    Get Alert Text
POST	/session/{session id}/ alert / text    Send Alert Text
GET	/session/{session id}/ screenshot    Take Screenshot
GET	/session/{session id}/ element /{ element id}/ screenshot   Take Element Screenshot
POST	/session/{session id}/ print Print Page
        */
    }
}