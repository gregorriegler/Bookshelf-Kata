import pytest

from db.db_factory import DbFactory
from db2.db import Db


@pytest.mark.skip(reason="dont bother the kata solver")
def test_db1():
    db_factory = DbFactory.get_instance()
    db = db_factory.start_db()
    assert db.find_all() == []

    db.persist("thing")
    assert db.find_all() == ["thing"]

    db.persist("another thing")
    assert db.find_all() == ["thing", "another thing"]

    db.clear()
    assert db.find_all() == []



@pytest.mark.skip(reason="dont bother the kata solver")
def test_db2():
    db = Db()
    assert db.find_all() == []
    assert db.count() == 0

    db.save("thing")
    assert db.find_all() == ["thing"]
    assert db.count() == 1

    db.save("another thing")
    assert db.find_all() == ["thing", "another thing"]
    assert db.count() == 2

    db.clear()
    assert db.find_all() == []
    assert db.count() == 0
