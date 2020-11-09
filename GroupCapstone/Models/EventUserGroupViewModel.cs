﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupCapstone.Models
{
    public class EventUserGroupViewModel
    {
        public IEnumerable<Group> Groups { get; set; }

        public IEnumerable<UserGroup> UserGroups { get; set; }

        public string UserName { get; set; }

        public IEnumerable<Event> Events { get; set; }
    }
}
