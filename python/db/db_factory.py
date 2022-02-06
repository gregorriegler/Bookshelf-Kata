import time
from dataclasses import dataclass


class DbFactory:
    __instance = None

    @classmethod
    def get_instance(cls):
        if cls.__instance is None:
            cls.__instance = DbFactory()
        return cls.__instance

    def start_db(self):
        tmp = DbFactory.Db.__init__
        DbFactory.Db.__init__ = lambda *args, **kwargs: None
        ret = DbFactory.Db()
        DbFactory.Db.__init__ = tmp
        time.sleep(3)
        return ret

    @dataclass
    class Db:
        __objects = []

        def __init__(self):
            raise TypeError("Use DbFactory!")

        def persist(self, thing):
            time.sleep(3)
            self.__objects.append(thing)

        def find_all(self):
            time.sleep(3)
            return self.__objects

        def clear(self):
            self.__objects.clear()
