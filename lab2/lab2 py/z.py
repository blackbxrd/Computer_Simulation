import matplotlib.pyplot as plt
import numpy as np

# константы: ускорение свободного падения и безопасная скорость приземления
g = 9.81
v_safety = 5  # м/с

# диапазон значений площади сечения парашюта от 10 до 100 м²
S_min = 10
S_max = 100
S_step = 5
S_array = np.arange(S_min, S_max + S_step, S_step)

# высота прыжка от 1 до 10 м с шагом 1 м
h_min = 100
h_max = 1000
h_step = 100
h_array = np.arange(h_min, h_max + h_step, h_step)

# матрица значений скорости приземления
v_array = np.zeros((len(S_array), len(h_array)))
for i in range(len(S_array)):
    for j in range(len(h_array)):
        v_array[i][j] = np.sqrt(2 * g * h_array[j] / (1.2 * S_array[i]))  # плотность воздуха 1.2 кг/м³

# график
fig, ax = plt.subplots()
for i in range(len(S_array)):
    ax.plot(h_array, v_array[i], label=f'S={S_array[i]} м²')
ax.axhline(y=v_safety, linestyle='--', color='red', label='Безопасная скорость приземления')
ax.legend()
ax.set_xlabel('Высота прыжка, м')
ax.set_ylabel('Скорость приземления, м/с')
ax.grid()
plt.show()