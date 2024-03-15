FROM ubuntu:latest
RUN apt-get update && apt-get install -y python3 \
    python3-pip
RUN pip3 install jupyter
RUN pip3 install numpy
RUN pip3 install pandas
RUN pip3 install statsmodels
RUN pip3 install matplotlib
RUN pip3 install plotly
RUN pip3 install seaborn
RUN pip3 install scikit-learn	
RUN pip3 install tensorflow
RUN useradd -ms /bin/bash jupyter
USER jupyter
WORKDIR /home/jupyter
RUN mkdir -p /home/jupyter/mvc/wwwroot/img
RUN mkdir -p /home/jupyter/mvc/wwwroot/json
RUN chown -R jupyter:jupyter /home/jupyter/mvc/wwwroot/img /home/jupyter/mvc/wwwroot/json
ENTRYPOINT ["jupyter", "notebook", "--ip=*", "Use --allow-root"]


