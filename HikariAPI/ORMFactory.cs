﻿#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：HikariAPI
* 项目描述 ：
* 类 名 称 ：ORMFactory
* 类 描 述 ：
* 命名空间 ：HikariAPI
* CLR 版本 ：4.0.30319.42000
* 作    者 ：jinyu
* 创建时间 ：2019
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ jinyu 2019. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion



using Hikari.Integration.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HikariAPI
{
    /* ============================================================================== 
* 功能描述：ORMFactory 
* 创 建 者：jinyu 
* 创建日期：2019 
* 更新时间 ：2019
* ==============================================================================*/

  public  class ORMFactory
    {
        public static IORM Create(string name=null)
        {
            return new SqlMapper(name);
        }
    }
}
