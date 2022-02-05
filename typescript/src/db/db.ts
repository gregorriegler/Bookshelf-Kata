export default class DbFactory {

    private static _instance: DbFactory;

    constructor() {
        if (DbFactory._instance) {
            return DbFactory._instance
        }
        DbFactory._instance = this;
    }

    async startDb(): Promise<Db> {
        await sleep(7000);
        return new Db();
    }
}

class Db {

    private objects: any[]

    constructor() {
        this.objects = [];
    }

    async persist(object: any) {
        await sleep(3000);
        this.objects.push(object);
    }

    async findAll(): Promise<any[]> {
        await sleep(3000);
        return this.objects;
    }

    clear() {
        this.objects = [];
    }
}

function sleep(milliseconds: number) {
    return new Promise(resolve => setTimeout(resolve, milliseconds));
}
