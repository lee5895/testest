import os

from PIL import Image
from imaginairy_normal_map.model import create_normal_map_pil_img

#파이썬 파일 위치
script_dir = os.path.dirname(os.path.realpath(__file__))

Txtfile_name = "TxtPath.txt"
Txtfile_path = os.path.join(script_dir, Txtfile_name)

Changed_script_dir = script_dir.replace("\\", "/")
#갤러리 위치 값을 저장한 Txt파일 읽기
with open(Txtfile_path, 'r') as file:
    lines = file.readlines()
#용호가 갤러리에서 값을 어떻게 넘겨주는지 보고 변경할 것
imagePath = Changed_script_dir + "/" + lines[0] + ".jpg"
print(imagePath)
#modified_lines = []
#딱히 새로 txt파일 변경하는 게 아니라 그냥 넘겨도 될듯
#for line in lines:
#    modified_line = line.replace(lines[1], divide[0] + "_normal." + divide[1])
#    modified_lines.append(modified_line)
    
img = Image.open(imagePath) #원본
normal_img = create_normal_map_pil_img(img)
divide = imagePath.split('.')
normal_img.save(divide[0] + "_normal." + divide[1]) #생성본
