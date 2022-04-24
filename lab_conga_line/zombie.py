from adts.linked_list import LinkedList
from random import *


class CongaLine:
    def __init__(self):
        # if instance is not None:
        #     if not isinstance(instance, CongaLine):
        #         raise TypeError('Instance is not a CongaLine')

        self._conga_line = LinkedList()
        self._count = 0

        self.rainbow_brains()

    def engine(self, zombie: str):
        self._conga_line.prepend(zombie)
        self._count += 1

    def caboose(self, zombie: str):
        self._conga_line.append(zombie)
        self._count += 1

    def jump_in_line(self, position: int, zombie: str):
        if position > self._count:
            raise IndexError('The number you entered is more then the current in the conga line.')

        travel = self._conga_line.head

        for current in range(position):
            travel = travel.next

        self._conga_line.insert_before(travel.item, zombie)
        self._count += 1

    def everyone_out(self, zombie: str):
        travel = self._conga_line.head
        index = 0

        while travel is not None:
            if travel.item is zombie:
                if travel.item == self._conga_line.head.item and index == 0:
                    # code goes here
                    new_head = travel.next
                    new_head.previous = None
                    self._conga_line._head = new_head
                elif travel.item == self._conga_line.tail.item and index == self._count - 1:
                    # code goes here
                    new_tail = travel.previous
                    new_tail.next = None
                    self._conga_line._tail = new_tail
                else:
                    nxt = travel.next
                    prev = travel.previous
                    prev.next = nxt.item
                    nxt.previous = prev.item
                self._count -= 1
                self._conga_line._count -= 1
            travel = travel.next
            index += 1

    def your_done(self, zombie: str):
        travel = self._conga_line.head
        index = 0

        while travel is not None:
            if travel.item is zombie:
                if travel.item == self._conga_line.head.item and index == 0:
                    # code goes here
                    new_head = travel.next
                    new_head.previous = None
                    self._conga_line._head = new_head
                elif travel.item == self._conga_line.tail.item and index == self._count - 1:
                    # code goes here
                    new_tail = travel.previous
                    new_tail.next = None
                    self._conga_line._tail = new_tail
                else:
                    nxt = travel.next
                    prev = travel.previous
                    prev.next = nxt.item
                    nxt.previous = prev.item
                self._count -= 1
                self._conga_line._count -= 1
                break
            travel = travel.next
            index += 1

    def brains(self):
        zombies = ['R', 'Y', 'G', 'B', 'M', 'C']

        zombie_choose = choice(zombies)

        self.engine(zombie_choose)
        self.caboose(zombie_choose)

    def rainbow_brains(self):
        zombies = ['R', 'Y', 'G', 'B', 'M', 'C']
        shuffle(zombies)

        for zombie in zombies:
            self._conga_line.append(zombie)
            self._count += 1

    def __str__(self):
        zombies = []
        travel = self._conga_line.head
        while travel is not None:
            zombies.append(travel.item)
            travel = travel.next
        return str(f'Size: {self._count} :: {zombies}')
