import DbFactory from "../src/db/db";
import Db from "../src/db2/db"

xdescribe('Db', function() {
    it('v1', async function () {
        this.timeout(20000); // mocha default timeout is 2000 ms
        let db = await new DbFactory().startDb();
        expect(await db.findAll()).to.be.empty;

        await db.persist("hello");
        expect(await db.findAll()).to.contain("hello");

        db.clear();
        expect(await db.findAll()).to.be.empty;
    })

    it('v2', async function () {
        this.timeout(20000); // mocha default timeout is 2000 ms
        let db = new Db();
        expect(await db.findAll()).to.be.empty;
        expect(await db.count()).to.equal(0);

        await db.save("hello");
        expect(await db.findAll()).to.contain("hello");
        expect(await db.count()).to.equal(1);

        db.clear();
        expect(await db.findAll()).to.be.empty;
        expect(await db.count()).to.equal(0);
    })
});
