"use strict"

export default class Db {
    constructor() {
        this.objects = [];
    }

    async save(object) {
        await sleep(500);
        this.objects.push(object);
    }

    async findAll() {
        await sleep(500);
        return this.objects;
    }

    async count() {
        await sleep(500);
        return this.objects.length;
    }

    clear() {
        this.objects = [];
    }
}

function sleep(milliseconds) {
    return new Promise(resolve => setTimeout(resolve, milliseconds));
}
