![DEKMACO Logo](https://dekamco.com/images/logo.png)

# HERBZHUB

![Version](https://img.shields.io/badge/dynamic/json?url=http%3A%2F%2Fherbzhub.com%2Fcredits%2Fversion.json&query=%24.version&style=flat&logoColor=white&logoSize=auto&label=Version&labelColor=grey&color=blue&cacheSeconds=3600&link=https%3A%2F%2Fgithub.com%2Fdekamco%2FHerbzHub)
![.NET](https://img.shields.io/badge/.NET-6.0-blue)
![React](https://img.shields.io/badge/React-17.0.2-blue)
![PyPI - Python Version](https://img.shields.io/pypi/pyversions/fastapi)
![npm](https://img.shields.io/npm/v/npm)
![Maintenance](https://img.shields.io/maintenance/yes/2024)

**Herbal Delivery System**, also known as **HerbzHub**, is an consumer-driven delivery system. Utilizing complex models, it efficiently gets herbal products to consumers with secure delivery.

## 📌 Overview

HerbzHub is a cutting-edge data, logistics, and inventory system platform designed for herbal products. It leverages advanced technology to ensure fast, secure, and efficient delivery of herbal products directly to B2C and B2B consumers. With its intuitive interface and robust backend, HerbzHub offers a seamless experience for both customers and suppliers.

## 🔧 Technical Details

CI/CD core components include:

- Github Actions

HerbzHub's core components include:

- **.NET Backend**: Provides robust APIs for handling data transactions.
- **React.js Frontend**: Offers a dynamic and responsive user interface.
- **Python HHOS**: Operating system for IoT devices.
- **Database Management**: Utilizes SQLAlchemy for efficient database management and operations.
- **Containerization**: Implemented using Docker, ensuring easy deployment and scalability.

## 💼 Getting Started

To get started with HerbzHub, follow the instructions for each component:

### Backend Setup (.NET)

1. **Clone the Repository:**

   `git clone https://github.com/your-repo/herbzhub.git`
   `cd herbzhub/backend/Herbzhub/src`

2. **Set Up Environment:**

   Ensure you have .NET 6.0 SDK installed.

3. **Install Dependencies:**

   `dotnet restore`

4. **Configure Environment Variables:**

   Create a `.env` file in the `Herbzhub.Api` directory with the necessary environment variables.

5. **Run the Application:**

   `dotnet run --project Herbzhub.Api`

   The backend should now be running on `http://localhost:5000`.

### Frontend Setup (React)

1. **Navigate to the Frontend Directory:**

   `cd herbzhub/frontend/web`

2. **Install Dependencies:**

   `npm install`

3. **Configure Environment Variables:**

   Create a `.env` file in the `src` directory with the necessary environment variables.

4. **Run the Application:**

   `npm start`

   The frontend should now be running on `http://localhost:3000`.

### Python HHOS Setup (Operating System for IoT Devices)

1. **Navigate to the HHOS Directory:**

   `cd herbzhub/hhos`

2. **Set Up a Virtual Environment:**

   `python -m venv venv`
   `source venv/bin/activate`  # On Windows use `venv\Scripts\activate`

3. **Install Dependencies:**

   `pip install -r requirements.txt`

4. **Run the Application:**

   `uvicorn app.main:app --reload`

   The HHOS should now be running on `http://localhost:8000`.

## 🔍 Future Development

HerbzHub is continuously evolving. Future enhancements include:

- Improved AI models for product recommendations.

- Expanded delivery network for wider coverage.

- Enhanced security features for data protection.

- Development Roadmap:

- Integration with additional payment gateways.

- Implementation of a user feedback system.

- Continuous UI/UX improvements.

## 🤝 Contributing

Contributions to HERBZHUB are welcomed. For feature requests, bug reports, or improvement proposals, please open an issue or submit a pull request. Note: This is for DEKAMCO employees only.

## 🙌 Acknowledgments

A huge shoutout to the brains behind HERBZHUB 🌟:
- Christian Stayton
- Dami Gideon
- Dolapo Afolabi
- Sajjad Ali
- Pratik Jajal


