import time


class DbFactory:

    __instance = None

    @classmethod
    def get_instance(cls):
        if cls.__instance is None:
            cls.__instance = DbFactory()
        return cls.__instance

    def start_db(self):
        return Db()


class Db:

    __objects = []

    def __init__(self):
        time.sleep(7)

    def persist(self, thing):
        time.sleep(3)
        self.__objects.append(thing)

    def find_all(self):
        time.sleep(3)
        return self.__objects

    def clear(self):
        self.__objects.clear()

