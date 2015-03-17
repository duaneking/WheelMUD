﻿// <auto-generated />
//-----------------------------------------------------------------------------
// <copyright file="HelpTopicRepository.cs" company="WheelMUD Development Team">
//   Copyright (c) WheelMUD Development Team. See LICENSE.txt. This file is
//   subject to the Microsoft Public License. All other rights reserved.
// </copyright>
// <summary>
//   auto-generated by Repository.cst on 4/9/2013 4:29:50 PM
// </summary>
//-----------------------------------------------------------------------------

namespace WheelMUD.Data.Repositories
{
    using System.Collections.Generic;
    using System.Data;
    using ServiceStack.OrmLite;
    using WheelMUD.Data.Entities;
    
    ///<summary>
    /// Repository for the HelpTopics table.
    ///</summary>
    public partial class HelpTopicRepository : IHelpTopicRepository
    {		
        #region IHelpTopicRepository Members

        public void Add(HelpTopicRecord helptopic)
        {
            using (IDbCommand session = Helpers.OpenSession())
                using (IDbTransaction transaction = session.Connection.BeginTransaction())
                {
                    session.Connection.Save(helptopic);
                    transaction.Commit();
                }
        }

        public void Update(HelpTopicRecord helptopic)
        {
            using (IDbCommand session = Helpers.OpenSession())
                using (IDbTransaction transaction = session.Connection.BeginTransaction())
                {
                    session.Connection.Update(helptopic);
                    transaction.Commit();
                }
        }

        public void Remove(HelpTopicRecord helptopic)
        {
            using (IDbCommand session = Helpers.OpenSession())
                using (IDbTransaction transaction = session.Connection.BeginTransaction())
                {
                    session.Connection.Delete(helptopic);
                    transaction.Commit();
                }
        }
        
        public HelpTopicRecord GetById(long helptopicId)
        {
            using (IDbCommand session = Helpers.OpenSession())
                return session.Connection.SingleWhere<HelpTopicRecord>("ID = {0}", helptopicId);
        }		

        public HelpTopicRecord GetByName(string name)
        {
            using (IDbCommand session = Helpers.OpenSession())
            {
                return session.Connection.SingleWhere<HelpTopicRecord>("Name = {0}", name);
            }
        }

        public ICollection<HelpTopicRecord> FetchAll()
        {
            using (IDbCommand session = Helpers.OpenSession())
            {
                return session.Connection.Select<HelpTopicRecord>();
            }
        }

        #endregion
    }
}