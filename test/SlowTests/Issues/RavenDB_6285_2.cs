﻿using System.Threading.Tasks;
using SlowTests.Server.Documents.Notifications;
using Tests.Infrastructure;
using Xunit;
using Xunit.Abstractions;

namespace SlowTests.Issues
{
    public class RavenDB_6285_2 : NoDisposalNoOutputNeeded
    {
        public RavenDB_6285_2(ITestOutputHelper output) : base(output)
        {
        }
        
        [Fact]
        public async Task CanGetAllNotificationAboutDocument_ALotOfDocuments()
        {
            using (var x = new ChangesTests(Output))
            {
                await x.CanGetAllNotificationAboutDocument_ALotOfDocuments();
            }
        }
    }
}
