import datetime

def main():
    # start time
    start_time = datetime.datetime.now()
    print("Start Time: ", start_time)

    # Action
    for i in range(1000000):
        print(i)

    # end time
    end_time = datetime.datetime.now()
    print("End Time: ", end_time)

    # Calculate total time
    total_time = end_time - start_time
    print("Total Time: ", total_time)

if __name__ == "__main__":
    main()
