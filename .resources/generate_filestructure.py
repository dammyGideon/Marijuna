import os

def scan_directory(directory, ignore_files=None, ignore_dirs=None):
    if ignore_files is None:
        ignore_files = []
    if ignore_dirs is None:
        ignore_dirs = []

    file_structure = []

    for root, dirs, files in os.walk(directory):
        # Ignore specified directories
        dirs[:] = [d for d in dirs if d not in ignore_dirs]

        level = root.replace(directory, '').count(os.sep)
        indent = '│   ' * level
        file_structure.append(f"{indent}├── {os.path.basename(root)}/")

        sub_indent = '│   ' * (level + 1)
        for f in files:
            if f not in ignore_files:
                file_structure.append(f"{sub_indent}├── {f}")

    return file_structure

def write_file_structure(file_structure, output_file):
    with open(output_file, 'w', encoding='utf-8') as f:
        f.write("# File Structure\n")
        f.write("===============\n\n")
        for line in file_structure:
            f.write(line + '\n')

def main():
    directory_to_scan = 'C:\\HerbzHub\\.'  # Replace with the directory you want to scan
    output_file = 'file_structure.md'

    ignore_files = [
        '.pnp', '.pnp.js', '.DS_Store', 'npm-debug.log', 'yarn-debug.log', 
        'yarn-error.log',
        # .NET specific ignore files
        'appsettings.json', 'appsettings.Development.json', 'appsettings.Production.json',
        'appsettings.Test.json', 'web.config', 'packages.config', '*.csproj', '*.sln'
    ]
    
    ignore_dirs = [
        'node_modules', 'coverage', 'build', 'venv', '.tmp.driveupload', 
        '.tmp.drivedownload', '.vs', '.git', '__pycache__', 'backups',
        # .NET specific ignore directories
        'bin', 'obj', 'Properties', '.vs', 'Migrations'
    ]

    if not os.path.isdir(directory_to_scan):
        print(f"Directory '{directory_to_scan}' does not exist.")
        return

    file_structure = scan_directory(directory_to_scan, ignore_files, ignore_dirs)
    write_file_structure(file_structure, output_file)
    print(f"File structure written to {output_file}")

if __name__ == "__main__":
    main()
