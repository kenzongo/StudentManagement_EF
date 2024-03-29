﻿using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementRepository
{
    public interface IAccountRepository
    {
        List<Account> GetAll();
        Account GetAccountByEmail(string email);
        bool AddAccount(Account account);
    }
}
