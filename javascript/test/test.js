import DbFactory from "../src/db/db";

describe('World', function() {
    it('red', async function () {
        this.timeout(20000); // mocha default timeout is 2000 ms
        let db = await new DbFactory().startDb();

        await db.persist("hello");
        expect(await db.findAll()).to.contain("hello")

        db.clear();
        expect(await db.findAll()).to.be.empty
    })
});
