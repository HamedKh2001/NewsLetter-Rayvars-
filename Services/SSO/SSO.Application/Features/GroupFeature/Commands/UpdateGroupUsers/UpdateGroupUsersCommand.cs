﻿using MediatR;
using System.Collections.Generic;

namespace SSO.Application.Features.GroupFeature.Commands.UpdateGroupUsers
{
    public class UpdateGroupUsersCommand : IRequest
    {
        public long GroupId { get; set; }
        public List<long> UserIds { get; set; }
    }
}
