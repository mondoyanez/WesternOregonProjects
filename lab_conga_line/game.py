from lab_conga_line.zombie import CongaLine


class Game:
    def __init__(self):
        self._round = 0
        self._game = CongaLine()

    def logic(self, option: int):
        if option == 0:
            print('Enter a zombie color you would like to enter from the following list...')
            print('[R, Y, G, B, M, C]')
            choose = input('Enter zombie: ')
            self._game.engine(choose)
            self._round += 1
        elif option == 1:
            print('Enter a zombie color you would like to enter from the following list...')
            print('[R, Y, G, B, M, C]')
            choose = input('Enter zombie: ')
            self._game.caboose(choose)
            self._round += 1
        elif option == 2:
            print(f'Pick position from: 0 to {self._game._count - 1}')
            index = int(input('Enter: '))
            print('Enter a zombie color you would like to enter from the following list...')
            print('[R, Y, G, B, M, C]')
            choose = input('Enter zombie: ')
            self._game.jump_in_line(index, choose)
            self._round += 1
        elif option == 3:
            print('Enter a zombie color you would like to remove from the following list...')
            print('[R, Y, G, B, M, C]')
            choose = input('Enter zombie: ')
            self._game.everyone_out(choose)
            self._round += 1
        elif option == 4:
            print('Enter a zombie color you would like to remove from the following list...')
            print('[R, Y, G, B, M, C]')
            choose = input('Enter zombie: ')
            self._game.your_done(choose)
            self._round += 1
        elif option == 5:
            self._game.brains()
            self._round += 1
        elif option == 6:
            self._game.rainbow_brains()
            self._round += 1
        elif option == 7:
            self.print()
        elif option == 8:
            quit()
        self.menu()

    def print(self):
        print(f'Round: {self._round}')
        print(f'The Zombie Party keeps on groaning!')
        print(self._game)

    def menu(self):
        selection = 7
        print('What would you like to do?')
        print('0: Engine\n1: Caboose\n2: Jump in line\n3: Everyone Out\n4: You\'re done\n5: Brains\n6: Rainbow Brains'
              '\n7: Print\n8: Quit')
        selection = int(input('Enter: '))

        if selection > 8 or selection < 0:
            print('Improper input please select something that is in the menu...')
            selection = 7

        self.logic(selection)
