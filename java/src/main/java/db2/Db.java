package db2;

import java.util.ArrayList;
import java.util.List;

/**
 * This is an external library you don't own.
 * You are not allowed to change it.
 */
public class Db<T> {
    private final List<T> objects = new ArrayList<>();

    public Db() {
        sleepSilently(2000);
    }

    public void save(T object) {
        sleepSilently(500);
        objects.add(object);
    }

    public List<T> findAll() {
        sleepSilently(500);
        return objects;
    }

    public int count() {
        sleepSilently(500);
        return objects.size();
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
