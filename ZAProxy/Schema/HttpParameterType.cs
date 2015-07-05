﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAProxy.Schema
{
    /// <summary>
    /// Describes the type of an http parameter.
    /// </summary>
    public enum HttpParameterType
    {
        /// <summary>
        /// Parameter is part of the cookies.
        /// </summary>
        Cookie,

        /// <summary>
        /// Parameter is part of the form values.
        /// </summary>
        Form,

        /// <summary>
        /// Parameter is part of the url query string.
        /// </summary>
        Url
    }
}
