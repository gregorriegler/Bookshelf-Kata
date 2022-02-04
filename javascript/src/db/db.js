"use strict"

export default class DbFactory {
    constructor() {
        if (DbFactory._instance) {
            return DbFactory._instance
        }
        DbFactory._instance = this;
    }

    async startDb() {
        await sleep(7000);
        return new Db();
    }
}

class Db {
    constructor() {
        this.objects = [];
    }

    async persist(object) {
        await sleep(3000);
        this.objects.push(object);
    }

    async findAll() {
        await sleep(3000);
        return this.objects;
    }

    clear() {
        this.objects = [];
    }



}

function sleep(milliseconds) {
    return new Promise(resolve => setTimeout(resolve, milliseconds));
}
