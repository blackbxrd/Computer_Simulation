import math
import matplotlib.pyplot as plt

# Функция для вычисления периода колебаний маятника
def calculate_period(length):
    g = 9.81  # Ускорение свободного падения в м/с^2
    T = 2 * math.pi * math.sqrt(length / g)
    return T

# Создание списка значений длины нити подвеса (от 0,1 до 1 метра с шагом 0,01 м)
lengths = [i/100 for i in range(10, 101)]

# Вычисление периода колебаний для каждого значения длины нити подвеса
periods = [calculate_period(length) for length in lengths]

# Построение графика зависимости периода колебаний от длины нити подвеса
fig, (ax1, ax2) = plt.subplots(nrows=2, ncols=1, figsize=(8, 8))
ax1.plot(lengths, periods)
ax1.set_title("Зависимость периода колебаний маятника от длины нити подвеса")
ax1.set_xlabel("Длина нити подвеса (м)")
ax1.set_ylabel("Период колебаний (с)")
ax1.grid(True)

# Построение синусоиды для первого значения длины нити подвеса
amplitude = math.pi / 2  # Амплитуда колебаний
t = [i/100 for i in range(0, 201)]  # Список значений времени (от 0 до 2 секунды с шагом 0,01 с)
length = lengths[0]  # Длина нити подвеса, используемая для вычисления периода
y = [amplitude * math.sin(2 * math.pi / calculate_period(length) * time) for time in t]  # Список значений отклонения маятника в зависимости от времени
ax2.plot(t, y)
ax2.set_title(f"Отклонение маятника для длины нити подвеса {length:.2f} м")
ax2.set_xlabel("Время (с)")
ax2.set_ylabel("Отклонение (м)")
ax2.grid(True)

# Отображение графиков
plt.show()