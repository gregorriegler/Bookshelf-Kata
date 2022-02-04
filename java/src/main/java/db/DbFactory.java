package db;

public class DbFactory {

    private static final DbFactory instance = new DbFactory();

    public static DbFactory getInstance() {
        return instance;
    }

    public <T> Db<T> startDb(Class<T> clazz) {
        return new Db<T>();
    }

}
