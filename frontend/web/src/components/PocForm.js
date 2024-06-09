/* src/components/PocForm.js */
// Package Block
import { useState, useEffect } from 'react';
import { Spin } from 'antd';
import { CustomStates } from '../utils/constant';

//  Custom Component Block
import { InputField, Button } from '../components';
import { getAllStates } from '../services/states';

// Assets Block
const PocForm = ({ formData, handleInputChange, handleSubmit }) => {
  const [loader, setLoader] = useState(false);
  const [states, setStates] = useState(CustomStates);

  // Getting Data of Counties & States
  const getStates = async () => {
    setLoader(true);
    try {
      const response = await getAllStates();
      setStates(response?.data?.data);
      setLoader(false);
    } catch (error) {
      console.log('🚀 ~ getStates ~ error:', error);
      setLoader(false);
    }
  };

  useEffect(() => {
    getStates();
  }, []);

  return (
    <Spin spinning={loader}>
      <form onSubmit={handleSubmit}>
        <h3>Organization Representative Information</h3>
        <label className="form-subtitle">
          Enter your personal information.
        </label>
        <label className="form-subtitle">
          This information will be used for identification verification.
        </label>
        <div className="input-pair">
          <InputField
            type="text"
            placeholder="First Name"
            name="firstName"
            value={formData.firstName}
            onChange={handleInputChange}
            required
          />
          <InputField
            type="text"
            placeholder="Last Name"
            name="lastName"
            value={formData.lastName}
            onChange={handleInputChange}
            required
          />
        </div>
        <div className="input-pair">
          <InputField
            type="text"
            placeholder="Phone Number"
            name="phoneNumber"
            value={formData.phoneNumber}
            onChange={handleInputChange}
            required
          />
          <InputField
            type="email"
            placeholder="E-Mail"
            name="email"
            value={formData.email}
            onChange={handleInputChange}
            required
            pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$"
          />
        </div>
        <div className="input-pair">
          <InputField
            type="text"
            placeholder="Address"
            name="streetAddress"
            value={formData.streetAddress}
            onChange={handleInputChange}
            required
          />
          <InputField
            type="text"
            placeholder="City"
            name="usersCity"
            value={formData.usersCity}
            onChange={handleInputChange}
            required
          />
        </div>
        <div className="input-pair">
          <select
            name="usersState"
            value={formData.usersState}
            onChange={handleInputChange}
            required
            className="select-field"
          >
            <option value="">Select State</option>
            {states?.map((state, index) => (
              <option key={index} value={state?.id}>
                {state?.name}
              </option>
            ))}
          </select>
          <InputField
            type="text"
            placeholder="Zip"
            name="usersZipCode"
            value={formData.usersZipCode}
            onChange={handleInputChange}
            required
          />
        </div>
        <Button type="submit" className="button">
          Continue
        </Button>
      </form>
    </Spin>
  );
};

export default PocForm;
