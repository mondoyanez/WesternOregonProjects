import unittest

from lab_conga_line.zombie import CongaLine


class CongaTest(unittest.TestCase):
    def setUp(self):
        line = ['R', 'Y', 'G', 'B', 'M', 'C']
        self._conga = CongaLine(line)

    def test_engine_value_added(self):
        # Arrange
        zombie = 'Y'

        # Act
        self._conga.engine(zombie)
        head = self._conga._conga_line.head.item

        # Assert
        self.assertEqual('Y', head)

    def test_engine_count_updated(self):
        # Arrange
        zombie = 'R'

        # Act
        self._conga.engine(zombie)
        head = self._conga._conga_line.head.item

        # Assert
        self.assertEqual(7, self._conga._count)

    def test_caboose_value_added(self):
        # Arrange
        zombie = 'C'

        # Act
        self._conga.caboose(zombie)
        tail = self._conga._conga_line.tail.item

        # Assert
        self.assertEqual('C', tail)

    def test_caboose_count_updated(self):
        # Arrange
        zombie = 'C'

        # Act
        self._conga.caboose(zombie)
        tail = self._conga._conga_line.tail.item

        # Assert
        self.assertEqual(7, self._conga._count)

    def test_jump_in_line_error_greater_than(self):
        # Arrange
        index = 10
        zombie = 'M'

        # Assert
        with self.assertRaises(IndexError):
            self._conga.jump_in_line(index, zombie)

    def test_jump_in_line_correct_value(self):
        # Arrange
        index = 3
        zombie = 'G'

        # Act
        self._conga.jump_in_line(index, zombie)

        travel = self._conga._conga_line.head
        for i in range(index):
            travel = travel.next

        item = travel.item

        # Assert
        self.assertEqual('G', item)

    def test_jump_in_line_count_updated(self):
        # Arrange
        index = 3
        zombie = 'G'

        # Act
        self._conga.jump_in_line(index, zombie)

        count = self._conga._count

        # Assert
        self.assertEqual(7, count)

    def test_everyone_out_correct_count(self):
        # Arrange
        zombie = 'B'

        # Act
        self._conga.everyone_out(zombie)
        count = self._conga._count
        correct_count = self._conga._conga_line._count

        # Assert
        self.assertEqual(correct_count, count)

    def test_everyone_out_correct_count_head(self):
        # Arrange
        zombie = 'B'
        self._conga._conga_line._head.item = zombie

        # Act
        self._conga.everyone_out(zombie)
        my_count = self._conga._count
        correct_count = self._conga._conga_line._count

        # Assert
        self.assertEqual(correct_count, my_count)

    def test_everyone_out_correct_count_tail(self):
        # Arrange
        zombie = 'B'
        self._conga._conga_line._tail.item = zombie

        # Act
        self._conga.everyone_out(zombie)
        my_count = self._conga._count
        correct_count = self._conga._conga_line._count

        # Assert
        self.assertEqual(correct_count, my_count)

    def test_your_done_correct_count(self):
        # Arrange
        zombie = 'B'

        # Act
        self._conga.your_done(zombie)
        count = self._conga._count
        correct_count = self._conga._conga_line._count

        # Assert
        self.assertEqual(correct_count, count)

    def test_your_done_correct_count_head(self):
        # Arrange
        zombie = 'B'
        self._conga._conga_line._head.item = zombie

        # Act
        self._conga.your_done(zombie)
        my_count = self._conga._count
        correct_count = self._conga._conga_line._count

        # Assert
        self.assertEqual(correct_count, my_count)

    def test_your_done_correct_count_tail(self):
        # Arrange
        zombie = 'B'
        self._conga._conga_line._tail.item = zombie

        # Act
        self._conga.your_done(zombie)
        my_count = self._conga._count
        correct_count = self._conga._conga_line._count

        # Assert
        self.assertEqual(correct_count, my_count)

if __name__ == '__main__':
    unittest.main()
