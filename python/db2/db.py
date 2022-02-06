import time


class Db:

    __objects = []

    def __init__(self):
        time.sleep(2)

    def save(self, thing):
        time.sleep(0.5)
        self.__objects.append(thing)

    def find_all(self):
        time.sleep(0.5)
        return self.__objects

    def count(self):
        time.sleep(0.5)
        return len(self.__objects)

    def clear(self):
        self.__objects.clear()