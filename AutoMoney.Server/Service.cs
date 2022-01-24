using System;
using System.Collections.Generic;
using System.Driver;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMoney.Server
{
    public class Service : IService
    {
        const string DB = "AutoMoney";
        private MongoClientAdvance MongoClientAdvance = new MongoClientAdvance("localhost:27017", "moka", "1234");

        public Member FindMember(Member member)
        {
            var filter = new List<Filter>();
            filter.Add(new Filter("account", member.account));
            filter.Add(new Filter("password", member.password));
            var findMember = this.MongoClientAdvance.FindOne<Member>(DB, "Member", filter);
            return findMember;
        }

        public bool SignUp(Member member)
        {
            if (member is null) { return false; }
            if (string.IsNullOrWhiteSpace(member.account)) { return false; }
            if (string.IsNullOrWhiteSpace(member.password)) { return false; }
            string collection = "Member";
            this.MongoClientAdvance.CreateIndex<Member>(DB, collection, true, "account");
            this.MongoClientAdvance.CreateIndex<Member>(DB, collection, false, "password");
            this.MongoClientAdvance.CreateIndex<Member>(DB, collection, false, "name");
            var isInsert = this.MongoClientAdvance.InsertOne(DB, collection, member);
            return isInsert;
        }
    }
}
