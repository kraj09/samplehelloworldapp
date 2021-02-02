using Domain.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MessageRepo : IMessage
    {
        public async Task<HelloWorldModel> GetMessage()
        {
            HelloWorldModel model = new HelloWorldModel()
            {
                Message = "Hello world"
            };

            await MyTaskAsync();
            return model;
        }

        public Task MyTaskAsync()
        {
            return Task.CompletedTask;
        }
    }
}
