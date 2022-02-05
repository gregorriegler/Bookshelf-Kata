export default class Db {

    private objects: any[]

    constructor() {
        this.objects = [];
    }

    async save(object: any) {
        await sleep(500);
        this.objects.push(object);
    }

    async findAll(): Promise<any[]> {
        await sleep(500);
        return this.objects;
    }

    async count(): Promise<number> {
        await sleep(500);
        return this.objects.length;
    }

    clear() {
        this.objects = [];
    }
}

function sleep(milliseconds: number) {
    return new Promise(resolve => setTimeout(resolve, milliseconds));
}
