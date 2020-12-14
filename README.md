# prothon
Generate .proto by .xlsx.  
Compile .proto

## Installation
```bash
pip install prothon
```

## Quick start
```python
import prothon


def generate_example():
    excel_path = 'YOUR EXCEL PATH'
    proto_name = 'YourProto.proto'

    proto = prothon.generate(excel_path)

    f = open(proto_name, 'w', encoding='utf8')
    f.write(proto)
    f.close()

#def compile_example():
#    proto_path = 'YOUR PROTO FILE PATH'
#  
#    code = prothon.generate
```
