package db;

import java.util.ArrayList;
import java.util.List;

public class Db<T> {
    private final List<T> objects = new ArrayList<>();

    Db() {
        sleepSilently(7000);
    }

    public void persist(T object) {
        sleepSilently(3000);
        objects.add(object);
    }

    public List<T> findAll() {
        sleepSilently(3000);
        return objects;
    }

    public void clear() {
        objects.clear();
    }

    private static void sleepSilently(int millis) {
        try {
            Thread.sleep(millis);
        } catch (InterruptedException ignored) {
        }
    }
}
